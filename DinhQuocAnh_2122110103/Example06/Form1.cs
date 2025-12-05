using System;
using System.Windows.Forms;

namespace Example06
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void chkGiamGia_CheckedChanged(object sender, EventArgs e)
        {
            txtPhanTram.Enabled = chkGiamGia.Checked;
            if (!chkGiamGia.Checked)
                txtPhanTram.Text = "0";
        }

        private void btnTinhTien_Click(object sender, EventArgs e)
        {
            string hoTen = txtHoTen.Text.Trim();
            if (hoTen == "")
            {
                MessageBox.Show("Vui lòng nh?p h? tên!");
                return;
            }

            string xungHo = rbNam.Checked ? "Ông" : "Bà";

            int giamGia = 0;
            if (chkGiamGia.Checked)
                int.TryParse(txtPhanTram.Text, out giamGia);

            txtKetQua.Text = $"{xungHo} {hoTen} ???c gi?m {giamGia}%";
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
