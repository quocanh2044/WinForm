namespace Example
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            tbYear = new TextBox();
            tbPhone = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 25);
            label1.Name = "label1";
            label1.Size = new Size(29, 15);
            label1.TabIndex = 0;
            label1.Text = "Year";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 65);
            label2.Name = "label2";
            label2.Size = new Size(88, 15);
            label2.TabIndex = 2;
            label2.Text = "Phone Number";
            // 
            // tbYear
            // 
            tbYear.Location = new Point(120, 22);
            tbYear.Name = "tbYear";
            tbYear.Size = new Size(150, 23);
            tbYear.TabIndex = 1;
            // 
            // tbPhone
            // 
            tbPhone.Location = new Point(120, 62);
            tbPhone.Name = "tbPhone";
            tbPhone.Size = new Size(150, 23);
            tbPhone.TabIndex = 3;
            // 
            // Form1
            // 
            ClientSize = new Size(310, 150);
            Controls.Add(label1);
            Controls.Add(tbYear);
            Controls.Add(label2);
            Controls.Add(tbPhone);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbYear;
        private System.Windows.Forms.TextBox tbPhone;
    }
}
