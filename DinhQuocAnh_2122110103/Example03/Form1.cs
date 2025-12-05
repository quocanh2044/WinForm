namespace Example03
{
    public partial class Form1 : Form
    {
        double value = 0;
        string operation = "";
        bool opPressed = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        // ============================
        //      ADD NUMBER
        // ============================

        private void AddNumber(string num)
        {
            // Nếu vừa bấm phép toán, thì xóa để nhập số mới
            if (opPressed || textBox1.Text == "0" || textBox1.Text == "+" || textBox1.Text == "*")
                textBox1.Text = "";

            opPressed = false;
            textBox1.Text += num;
        }

        private void button1_Click(object sender, EventArgs e) { AddNumber("0"); }
        private void button2_Click(object sender, EventArgs e) { AddNumber("1"); }
        private void button3_Click(object sender, EventArgs e) { AddNumber("2"); }
        private void button4_Click(object sender, EventArgs e) { AddNumber("3"); }

        // ============================
        //      SET OPERATION
        // ============================

        private void SetOperation(string op)
        {
            value = double.Parse(textBox1.Text); // Lưu số đầu tiên
            operation = op;
            opPressed = true;

            // Hiển thị dấu toán học lên textbox
            textBox1.Text = op;
        }

        private void button5_Click(object sender, EventArgs e)   // +
        {
            SetOperation("+");
        }

        private void button6_Click(object sender, EventArgs e)   // *
        {
            SetOperation("*");
        }

        // ============================
        //      DOT
        // ============================

        private void button8_Click(object sender, EventArgs e)
        {
            if (!textBox1.Text.Contains("."))
            {
                // Nếu đang hiển thị phép toán (+, *), không được thêm dấu .
                if (textBox1.Text == "+" || textBox1.Text == "*") return;

                textBox1.Text += ".";
            }
        }

        // ============================
        //      EQUALS
        // ============================

        private void button7_Click(object sender, EventArgs e)   // =
        {
            if (textBox1.Text == "+" || textBox1.Text == "*")
                return; // Không tính khi chỉ mới bấm phép toán

            double second = double.Parse(textBox1.Text);

            switch (operation)
            {
                case "+":
                    textBox1.Text = (value + second).ToString();
                    break;

                case "*":
                    textBox1.Text = (value * second).ToString();
                    break;
            }

            opPressed = false;
        }
    }
}
