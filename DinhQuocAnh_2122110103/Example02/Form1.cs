using System;
using System.Windows.Forms;

namespace Example02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Cộng
            try
            {
                double x = double.Parse(textBox1.Text);
                double y = double.Parse(textBox2.Text);
                textBox3.Text = (x + y).ToString();
            }
            catch
            {
                MessageBox.Show("Vui lòng nhập số hợp lệ!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Nhân
            try
            {
                double x = double.Parse(textBox1.Text);
                double y = double.Parse(textBox2.Text);
                textBox3.Text = (x * y).ToString();
            }
            catch
            {
                MessageBox.Show("Vui lòng nhập số hợp lệ!");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Thoát
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e) { }
        private void label2_Click(object sender, EventArgs e) { }
        private void label3_Click(object sender, EventArgs e) { }
    }
}
