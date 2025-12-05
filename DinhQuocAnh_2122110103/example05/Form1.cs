

namespace example05
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Thêm danh sách ngành vào ComboBox
            cbNganh.Items.AddRange(new string[]
            {
                "Công nghệ thông tin",
                "Ngoại ngữ",
                "Quản trị kinh doanh",
                "Cơ khí",
                "Điện",
                "Cơ khí động lực"
            });

            // Cho phép chọn
            cbNganh.Enabled = true;
        }

        private void cbNganh_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Ví dụ: show ngành khi chọn
            MessageBox.Show("Bạn đã chọn: " + cbNganh.SelectedItem);
        }
    }
}
