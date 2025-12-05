using System;
using System.Windows.Forms;

namespace Example09
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
         
        }

        // Nút > chuyển 1 bài sang phải
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (lstAllSongs.SelectedItem != null)
            {
                lstFavoriteSongs.Items.Add(lstAllSongs.SelectedItem);
                lstAllSongs.Items.Remove(lstAllSongs.SelectedItem);
            }
        }

        // Nút < chuyển 1 bài sang trái
        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (lstFavoriteSongs.SelectedItem != null)
            {
                lstAllSongs.Items.Add(lstFavoriteSongs.SelectedItem);
                lstFavoriteSongs.Items.Remove(lstFavoriteSongs.SelectedItem);
            }
        }

        // Nút >> chuyển tất cả sang phải
        private void btnAddAll_Click(object sender, EventArgs e)
        {
            foreach (var item in lstAllSongs.Items)
                lstFavoriteSongs.Items.Add(item);

            lstAllSongs.Items.Clear();
        }

        // Nút << chuyển tất cả sang trái
        private void btnRemoveAll_Click(object sender, EventArgs e)
        {
            foreach (var item in lstFavoriteSongs.Items)
                lstAllSongs.Items.Add(item);

            lstFavoriteSongs.Items.Clear();
        }
    }
}
