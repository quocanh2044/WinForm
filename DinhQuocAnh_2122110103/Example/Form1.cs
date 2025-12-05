using System;
using System.Windows.Forms;

namespace Example
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string year = tbYear.Text;
            string phone = tbPhone.Text;

            MessageBox.Show($"Year: {year}\nPhone: {phone}", "Thông tin");
        }
    }
}
