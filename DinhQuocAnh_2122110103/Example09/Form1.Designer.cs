namespace Example09
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

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            lstAllSongs = new ListBox();
            lstFavoriteSongs = new ListBox();
            btnAdd = new Button();
            btnRemove = new Button();
            btnAddAll = new Button();
            btnRemoveAll = new Button();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // lstAllSongs
            // 
            lstAllSongs.FormattingEnabled = true;
            lstAllSongs.ItemHeight = 15;
            lstAllSongs.Items.AddRange(new object[] { "Giấc mơ Chapi", "Đôi mắt Pleiku", "Em Muốn Sống Bên Anh Trọn Đời", "H’Zen Lên Rẫy", "Còn Thương Nhau Thì Về Buôn Mê Thuột", "Ly Cà Phê Ban Mê", "Đi tìm lời ru mặt trời" });
            lstAllSongs.Location = new Point(10, 26);
            lstAllSongs.Name = "lstAllSongs";
            lstAllSongs.Size = new Size(219, 304);
            lstAllSongs.TabIndex = 0;
            // 
            // lstFavoriteSongs
            // 
            lstFavoriteSongs.FormattingEnabled = true;
            lstFavoriteSongs.ItemHeight = 15;
            lstFavoriteSongs.Location = new Point(368, 26);
            lstFavoriteSongs.Name = "lstFavoriteSongs";
            lstFavoriteSongs.Size = new Size(218, 304);
            lstFavoriteSongs.TabIndex = 1;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(270, 69);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(53, 41);
            btnAdd.TabIndex = 2;
            btnAdd.Text = ">";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnRemove
            // 
            btnRemove.Location = new Point(270, 116);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(53, 41);
            btnRemove.TabIndex = 3;
            btnRemove.Text = "<";
            btnRemove.UseVisualStyleBackColor = true;
            btnRemove.Click += btnRemove_Click;
            // 
            // btnAddAll
            // 
            btnAddAll.Location = new Point(270, 163);
            btnAddAll.Name = "btnAddAll";
            btnAddAll.Size = new Size(53, 41);
            btnAddAll.TabIndex = 4;
            btnAddAll.Text = ">>";
            btnAddAll.UseVisualStyleBackColor = true;
            btnAddAll.Click += btnAddAll_Click;
            // 
            // btnRemoveAll
            // 
            btnRemoveAll.Location = new Point(270, 210);
            btnRemoveAll.Name = "btnRemoveAll";
            btnRemoveAll.Size = new Size(53, 40);
            btnRemoveAll.TabIndex = 5;
            btnRemoveAll.Text = "<<";
            btnRemoveAll.UseVisualStyleBackColor = true;
            btnRemoveAll.Click += btnRemoveAll_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 8);
            label1.Name = "label1";
            label1.Size = new Size(101, 15);
            label1.TabIndex = 6;
            label1.Text = "Danh sách bài hát";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(368, 8);
            label2.Name = "label2";
            label2.Size = new Size(147, 15);
            label2.TabIndex = 7;
            label2.Text = "Danh sách bài hát ưa thích";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(598, 347);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnRemoveAll);
            Controls.Add(btnAddAll);
            Controls.Add(btnRemove);
            Controls.Add(btnAdd);
            Controls.Add(lstFavoriteSongs);
            Controls.Add(lstAllSongs);
            Name = "Form1";
            Text = "Music List";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.ListBox lstAllSongs;
        private System.Windows.Forms.ListBox lstFavoriteSongs;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnAddAll;
        private System.Windows.Forms.Button btnRemoveAll;
        private Label label1;
        private Label label2;
    }
}
