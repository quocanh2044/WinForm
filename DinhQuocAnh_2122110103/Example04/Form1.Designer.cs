    namespace Example04
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
            cbNganh = new ComboBox();
            SuspendLayout();
            // 
            // cbNganh
            // 
            cbNganh.Font = new Font("Segoe UI", 10F);
            cbNganh.FormattingEnabled = true;
            cbNganh.Location = new Point(236, 56);
            cbNganh.Name = "cbNganh";
            cbNganh.Size = new Size(304, 25);
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

        private ComboBox cbNganh;
        }
    }
