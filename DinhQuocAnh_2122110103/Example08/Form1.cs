using System;
using System.Runtime.Intrinsics.Arm;
using System.Windows.Forms;

namespace Example08
{
    public partial class Form1 : Form
    {
        int index = 1;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string hoTen = txtHoTen.Text;
            string ngaySinh = dtNgaySinh.Value.ToString("dd/MM/yyyy");
            string gioiTinh = rdNam.Checked ? "Nam" : "Nữ";
            string khoa = cboKhoa.Text;

            lstTrangThai.Items.Add($"{index}. {hoTen}");
            lstTrangThai.Items.Add($" - Giới tính: {gioiTinh}");
            lstTrangThai.Items.Add($" - Ngày sinh: {ngaySinh}");
            lstTrangThai.Items.Add($" - Khoa: {khoa}");
            lstTrangThai.Items.Add("");

            index++;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
