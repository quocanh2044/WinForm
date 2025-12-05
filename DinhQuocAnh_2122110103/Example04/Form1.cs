namespace Example04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbNganh.Items.Clear();

            cbNganh.Items.Add("Công nghệ thông tin");
            cbNganh.Items.Add("Kế toán");
            cbNganh.Items.Add("Cơ khí");
            cbNganh.Items.Add("Điện");
            cbNganh.Items.Add("Hóa");

            cbNganh.SelectedItem = "Điện";
        }

        private void cbNganh_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}
