namespace Example07
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private DateTimePicker dtLong;
        private DateTimePicker dtShort;
        private DateTimePicker dtTime;
        private DateTimePicker dtCustom;
        private Label lblResult;
        private Button btnShow;

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
            this.dtLong = new System.Windows.Forms.DateTimePicker();
            this.dtShort = new System.Windows.Forms.DateTimePicker();
            this.dtTime = new System.Windows.Forms.DateTimePicker();
            this.dtCustom = new System.Windows.Forms.DateTimePicker();
            this.lblResult = new System.Windows.Forms.Label();
            this.btnShow = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dtLong
            // 
            this.dtLong.Location = new System.Drawing.Point(40, 25);
            this.dtLong.Name = "dtLong";
            this.dtLong.Size = new System.Drawing.Size(250, 22);
            // 
            // dtShort
            // 
            this.dtShort.Location = new System.Drawing.Point(40, 70);
            this.dtShort.Name = "dtShort";
            this.dtShort.Size = new System.Drawing.Size(250, 22);
            // 
            // dtTime
            // 
            this.dtTime.Location = new System.Drawing.Point(40, 115);
            this.dtTime.Name = "dtTime";
            this.dtTime.Size = new System.Drawing.Size(250, 22);
            // 
            // dtCustom
            // 
            this.dtCustom.Location = new System.Drawing.Point(40, 160);
            this.dtCustom.Name = "dtCustom";
            this.dtCustom.Size = new System.Drawing.Size(250, 22);
            // 
            // lblResult
            // 
            this.lblResult.Location = new System.Drawing.Point(40, 200);
            this.lblResult.Size = new System.Drawing.Size(280, 90);
            this.lblResult.Text = "Kết quả: ";
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(100, 305);
            this.btnShow.Size = new System.Drawing.Size(120, 32);
            this.btnShow.Text = "Hiển thị";
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(350, 360);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.dtCustom);
            this.Controls.Add(this.dtTime);
            this.Controls.Add(this.dtShort);
            this.Controls.Add(this.dtLong);
            this.Name = "Form1";
            this.Text = "DateTimePicker Demo";
            this.ResumeLayout(false);
        }
    }
}
