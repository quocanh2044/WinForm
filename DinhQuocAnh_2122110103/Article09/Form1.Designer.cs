namespace Article09
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblX;
        private System.Windows.Forms.Label lblY;
        private System.Windows.Forms.Label lblKQ;
        private System.Windows.Forms.TextBox txtX;
        private System.Windows.Forms.TextBox txtY;
        private System.Windows.Forms.ListBox lstKQ;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnCong;
        private System.Windows.Forms.Button btnNhan;
        private System.Windows.Forms.Button btnThoat;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblX = new System.Windows.Forms.Label();
            this.lblY = new System.Windows.Forms.Label();
            this.lblKQ = new System.Windows.Forms.Label();
            this.txtX = new System.Windows.Forms.TextBox();
            this.txtY = new System.Windows.Forms.TextBox();
            this.lstKQ = new System.Windows.Forms.ListBox();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnCong = new System.Windows.Forms.Button();
            this.btnNhan = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblX
            // 
            this.lblX.AutoSize = true;
            this.lblX.Location = new System.Drawing.Point(30, 30);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(32, 13);
            this.lblX.Text = "Số x:";
            // 
            // lblY
            // 
            this.lblY.AutoSize = true;
            this.lblY.Location = new System.Drawing.Point(30, 70);
            this.lblY.Name = "lblY";
            this.lblY.Size = new System.Drawing.Size(32, 13);
            this.lblY.Text = "Số y:";
            // 
            // lblKQ
            // 
            this.lblKQ.AutoSize = true;
            this.lblKQ.Location = new System.Drawing.Point(30, 110);
            this.lblKQ.Name = "lblKQ";
            this.lblKQ.Size = new System.Drawing.Size(46, 13);
            this.lblKQ.Text = "Kết quả:";
            // 
            // txtX
            // 
            this.txtX.Location = new System.Drawing.Point(90, 25);
            this.txtX.Width = 300;
            // 
            // txtY
            // 
            this.txtY.Location = new System.Drawing.Point(90, 65);
            this.txtY.Width = 300;
            // 
            // lstKQ
            // 
            this.lstKQ.Location = new System.Drawing.Point(90, 110);
            this.lstKQ.Size = new System.Drawing.Size(600, 300);
            // 
            // btnLuu
            // 
            this.btnLuu.Text = "Lưu";
            this.btnLuu.Location = new System.Drawing.Point(90, 430);
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnCong
            // 
            this.btnCong.Text = "Cộng";
            this.btnCong.Location = new System.Drawing.Point(230, 430);
            this.btnCong.Click += new System.EventHandler(this.btnCong_Click);
            // 
            // btnNhan
            // 
            this.btnNhan.Text = "Nhân";
            this.btnNhan.Location = new System.Drawing.Point(370, 430);
            this.btnNhan.Click += new System.EventHandler(this.btnNhan_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Text = "Thoát";
            this.btnThoat.Location = new System.Drawing.Point(510, 430);
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(750, 500);
            this.Controls.Add(this.lblX);
            this.Controls.Add(this.lblY);
            this.Controls.Add(this.lblKQ);
            this.Controls.Add(this.txtX);
            this.Controls.Add(this.txtY);
            this.Controls.Add(this.lstKQ);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnCong);
            this.Controls.Add(this.btnNhan);
            this.Controls.Add(this.btnThoat);
            this.Name = "Form1";
            this.Text = "Caculator";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
