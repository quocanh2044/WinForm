namespace Example06
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbNam;
        private System.Windows.Forms.RadioButton rbNu;
        private System.Windows.Forms.CheckBox chkGiamGia;
        private System.Windows.Forms.TextBox txtPhanTram;
        private System.Windows.Forms.TextBox txtKetQua;
        private System.Windows.Forms.Button btnTinhTien;
        private System.Windows.Forms.Button btnThoat;

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
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbNam = new System.Windows.Forms.RadioButton();
            this.rbNu = new System.Windows.Forms.RadioButton();
            this.chkGiamGia = new System.Windows.Forms.CheckBox();
            this.txtPhanTram = new System.Windows.Forms.TextBox();
            this.txtKetQua = new System.Windows.Forms.TextBox();
            this.btnTinhTien = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();

            this.groupBox1.SuspendLayout();
            this.SuspendLayout();

            // Font chung của form
            this.Font = new System.Drawing.Font("Segoe UI", 10F);

            // Label họ tên
            this.lblHoTen.AutoSize = true;
            this.lblHoTen.Location = new System.Drawing.Point(25, 10);
            this.lblHoTen.Text = "Họ tên:";

            // TextBox họ tên
            this.txtHoTen.Location = new System.Drawing.Point(25, 32);
            this.txtHoTen.Size = new System.Drawing.Size(350, 25);

            // GroupBox giới tính
            this.groupBox1.Controls.Add(this.rbNam);
            this.groupBox1.Controls.Add(this.rbNu);
            this.groupBox1.Location = new System.Drawing.Point(25, 75);
            this.groupBox1.Size = new System.Drawing.Size(350, 70);
            this.groupBox1.Text = "Giới tính";

            // Radio Nam
            this.rbNam.AutoSize = true;
            this.rbNam.Location = new System.Drawing.Point(40, 30);
            this.rbNam.Text = "Nam";
            this.rbNam.Checked = true;

            // Radio Nữ
            this.rbNu.AutoSize = true;
            this.rbNu.Location = new System.Drawing.Point(200, 30);
            this.rbNu.Text = "Nữ";

            // Check giảm giá
            this.chkGiamGia.AutoSize = true;
            this.chkGiamGia.Location = new System.Drawing.Point(25, 160);
            this.chkGiamGia.Text = "Giảm giá";
            this.chkGiamGia.CheckedChanged += new System.EventHandler(this.chkGiamGia_CheckedChanged);

            // Text phần trăm giảm
            this.txtPhanTram.Location = new System.Drawing.Point(120, 158);
            this.txtPhanTram.Size = new System.Drawing.Size(80, 25);
            this.txtPhanTram.Text = "7";
            this.txtPhanTram.Enabled = false;

            // TextBox kết quả
            this.txtKetQua.Location = new System.Drawing.Point(25, 200);
            this.txtKetQua.Multiline = true;
            this.txtKetQua.Size = new System.Drawing.Size(350, 90);

            // Button tính tiền
            this.btnTinhTien.Location = new System.Drawing.Point(80, 310);
            this.btnTinhTien.Size = new System.Drawing.Size(110, 32);
            this.btnTinhTien.Text = "Tính tiền";
            this.btnTinhTien.Click += new System.EventHandler(this.btnTinhTien_Click);

            // Button thoát
            this.btnThoat.Location = new System.Drawing.Point(220, 310);
            this.btnThoat.Size = new System.Drawing.Size(110, 32);
            this.btnThoat.Text = "Thoát";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);

            // Form settings
            this.ClientSize = new System.Drawing.Size(400, 360);
            this.Controls.Add(this.lblHoTen);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.chkGiamGia);
            this.Controls.Add(this.txtPhanTram);
            this.Controls.Add(this.txtKetQua);
            this.Controls.Add(this.btnTinhTien);
            this.Controls.Add(this.btnThoat);
            this.Text = "Ví dụ 6";

            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
