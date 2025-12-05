using System;
using System.Windows.Forms;

namespace Article09
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCong_Click(object sender, EventArgs e)
        {
            double x = double.Parse(txtX.Text);
            double y = double.Parse(txtY.Text);
            double kq = x + y;
            lstKQ.Items.Add(x + " + " + y + " = " + kq);
        }

        private void btnNhan_Click(object sender, EventArgs e)
        {
            double x = double.Parse(txtX.Text);
            double y = double.Parse(txtY.Text);
            double kq = x * y;
            lstKQ.Items.Add(x + " × " + y + " = " + kq);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Đã lưu kết quả!", "Thông báo");
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
