using System;
using System.ComponentModel;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace Example07
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            SetupPickers();
        }

        private void SetupPickers()
        {
            // 1. LONG DATE
            dtLong.Format = DateTimePickerFormat.Long;

            // 2. SHORT DATE
            dtShort.Format = DateTimePickerFormat.Short;

            // 3. TIME
            dtTime.Format = DateTimePickerFormat.Time;
            dtTime.ShowUpDown = true;

            // 4. CUSTOM
            dtCustom.Format = DateTimePickerFormat.Custom;
            dtCustom.CustomFormat = "dd/MM/yyyy";

            // EVENTS
            dtLong.ValueChanged += Dt_ValueChanged;
            dtShort.ValueChanged += Dt_ValueChanged;
            dtTime.ValueChanged += Dt_ValueChanged;
            dtCustom.ValueChanged += Dt_ValueChanged;

            dtCustom.Validating += dtCustom_Validating;
            dtCustom.Validated += dtCustom_Validated;
        }

        private void Dt_ValueChanged(object sender, EventArgs e)
        {
            lblResult.Text =
                "Long: " + dtLong.Value.ToLongDateString() +
                "\nShort: " + dtShort.Value.ToShortDateString() +
                "\nTime: " + dtTime.Value.ToLongTimeString() +
                "\nCustom: " + dtCustom.Value.ToString("dd/MM/yyyy");
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Long Date: " + dtLong.Value.ToLongDateString() +
                "\nShort Date: " + dtShort.Value.ToShortDateString() +
                "\nTime: " + dtTime.Value.ToLongTimeString() +
                "\nCustom Format: " + dtCustom.Value.ToString("dd/MM/yyyy"),
                "Thông tin"
            );
        }

        private void dtCustom_Validating(object sender, CancelEventArgs e)
        {
            if (dtCustom.Value > DateTime.Now)
            {
                e.Cancel = true;
                MessageBox.Show("Ngày không ???c l?n h?n hi?n t?i!");
            }
        }

        private void dtCustom_Validated(object sender, EventArgs e)
        {
            Console.WriteLine("Custom date h?p l?");
        }
    }
}
