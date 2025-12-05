using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;
using System.Xml.Linq;

namespace example05
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private ComboBox cbNganh;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            cbNganh = new ComboBox();
            SuspendLayout();
            // 
            // cbNganh
            // 
            cbNganh.Font = new System.Drawing.Font("Segoe UI", 14F);

            cbNganh.FormattingEnabled = true;
            cbNganh.Location = new Point(236, 56);
            cbNganh.Name = "cbNganh";
            cbNganh.Size = new Size(304, 33);
            cbNganh.TabIndex = 0;
            cbNganh.SelectedIndexChanged += cbNganh_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cbNganh);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion
    }
}
