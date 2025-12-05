namespace Example03
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = SystemColors.AppWorkspace;
            button1.Font = new Font("Segoe UI", 20F);
            button1.Location = new Point(258, 172);
            button1.Name = "button1";
            button1.Size = new Size(65, 53);
            button1.TabIndex = 0;
            button1.Text = "0";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.AppWorkspace;
            button2.Font = new Font("Segoe UI", 20F);
            button2.Location = new Point(329, 172);
            button2.Name = "button2";
            button2.Size = new Size(65, 53);
            button2.TabIndex = 1;
            button2.Text = "1";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.AppWorkspace;
            button3.Font = new Font("Segoe UI", 20F);
            button3.Location = new Point(400, 172);
            button3.Name = "button3";
            button3.Size = new Size(65, 53);
            button3.TabIndex = 2;
            button3.Text = "2";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.AppWorkspace;
            button4.Font = new Font("Segoe UI", 20F);
            button4.Location = new Point(471, 172);
            button4.Name = "button4";
            button4.Size = new Size(65, 53);
            button4.TabIndex = 3;
            button4.Text = "3";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.BackColor = SystemColors.AppWorkspace;
            button5.Font = new Font("Segoe UI", 20F);
            button5.ForeColor = SystemColors.ControlText;
            button5.Location = new Point(258, 247);
            button5.Name = "button5";
            button5.Size = new Size(65, 53);
            button5.TabIndex = 4;
            button5.Text = "+";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.BackColor = SystemColors.AppWorkspace;
            button6.Font = new Font("Segoe UI", 20F);
            button6.Location = new Point(329, 247);
            button6.Name = "button6";
            button6.Size = new Size(65, 53);
            button6.TabIndex = 5;
            button6.Text = "*";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.BackColor = SystemColors.AppWorkspace;
            button7.Font = new Font("Segoe UI", 20F);
            button7.Location = new Point(471, 247);
            button7.Name = "button7";
            button7.Size = new Size(65, 53);
            button7.TabIndex = 6;
            button7.Text = "=";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.BackColor = SystemColors.AppWorkspace;
            button8.Font = new Font("Segoe UI", 20F);
            button8.Location = new Point(400, 247);
            button8.Name = "button8";
            button8.Size = new Size(65, 53);
            button8.TabIndex = 7;
            button8.Text = ".";
            button8.UseVisualStyleBackColor = false;
            button8.Click += button8_Click;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 20F);
            textBox1.Location = new Point(258, 120);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(278, 43);
            textBox1.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox1);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private TextBox textBox1;
    }
}
