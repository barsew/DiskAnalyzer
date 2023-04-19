using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace lab4_forms
{
    public partial class DalogWindow : Form
    {

        public string selectedFolderPath;
        public DalogWindow()
        {
            InitializeComponent();

        }



        private void listView_Click(object sender, EventArgs e)
        {
            if(listView.SelectedItems.Count > 0)
            {
                selectedFolderPath = listView.SelectedItems[0].SubItems[0].Text;
            }
            listView.HideSelection = false;
            radioButtonIndividual.Select();
            listView.Select();
        }

        private void listView_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            radioButtonIndividual.Select();
            listView.Select();
        }



        private void buttonOk_Click(object sender, EventArgs e)
        {
            if (selectedFolderPath != null)
            {
                var main = (Form1)this.Owner;
                main.UpdateTreeView(selectedFolderPath);
                selectedFolderPath = null;
            }

            Close();
        }

        private void buttonFolders_Click(object sender, EventArgs e)
        {
            using (var folderBrowserDialog = new FolderBrowserDialog())
            {
                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    selectedFolderPath = folderBrowserDialog.SelectedPath;
                    textBoxFilePath.Text = selectedFolderPath;
                    radioButtonFolder.Select();
                }
            }
        }

        private void textBoxFilePath_TextChanged(object sender, EventArgs e)
        {
            string path = textBoxFilePath.Text;

            if (!File.Exists(path) && !Directory.Exists(path))
            {
                textBoxFilePath.ForeColor = Color.Red;
            }
            else
            {
                textBoxFilePath.ForeColor = Color.Black;
                selectedFolderPath = path;
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void DalogWindow_Load(object sender, EventArgs e)
        {
            // ListViewItem it = new ListViewItem("asdasd");
            //listView.Items.Add(it);
            var d = DriveInfo.GetDrives();
            foreach (var item in d)
            {
                if (item.IsReady)
                {

                    ListViewItem it = new ListViewItem(item.Name);
                    it.SubItems.Add(String.Format("{0} GB", Math.Round((double)item.TotalSize / (1024 * 1024 * 1024), 2)));
                    it.SubItems.Add(String.Format("{0} GB", Math.Round((double)item.AvailableFreeSpace / (1024 * 1024 * 1024), 2)));

                    double percentUsed = ((double)(item.TotalSize - item.AvailableFreeSpace) / item.TotalSize) * 100;
                    //System.Windows.Forms.ProgressBar progressBar = new System.Windows.Forms.ProgressBar();
                    //progressBar.Maximum = 100;
                    //progressBar.Value = (int)percentUsed;
                    //progressBar.Width = 100;
                    //progressBar.ForeColor = System.Drawing.Color.DarkBlue;
                    it.SubItems.Add(String.Format("{0}", percentUsed / 100));
                    //listView.CreateControl();
                    //listView.Controls.Add(progressBar);
                    //progressBar.Location = new System.Drawing.Point(340, it.Index * 20 + 4);
                    //// progressBar.BringToFront();
                    //progressBar.Style = ProgressBarStyle.Continuous;
                    //progressBar.Value = (int)percentUsed;
                    ////it.SubItems[3].BackColor = progressBar;
                    //progressBar.Visible = true;

                    it.SubItems.Add(String.Format("{0} GB", Math.Round((double)(item.TotalSize - item.AvailableFreeSpace) / (1024 * 1024 * 1024), 2)));

                    it.SubItems.Add(String.Format("{0:F2}%", percentUsed));

                    listView.Items.Add(it);
                }

            }
        }
        private void listView1_DrawColumnHeader(object sender, DrawListViewColumnHeaderEventArgs e)
        {
            e.DrawDefault = true;
        }

        private void listView1_DrawSubItem(object sender, DrawListViewSubItemEventArgs e)
        {
            if (e.ColumnIndex == 3)
            {
                int progress = (int)(double.Parse(e.SubItem.Text) * 100);
                int progressBarWidth = e.SubItem.Bounds.Width - 4;
                int progressBarHeight = e.SubItem.Bounds.Height - 4;
                int progressBarX = e.SubItem.Bounds.X + 2;
                int progressBarY = e.SubItem.Bounds.Y + 2;

                Brush brush0 = new SolidBrush(Color.LightGray);
                e.Graphics.FillRectangle(brush0, progressBarX, progressBarY, progressBarWidth, progressBarHeight);

                Brush brush = new SolidBrush(Color.DarkBlue);
                int fillWidth = (int)Math.Round((double)progress / 100 * progressBarWidth);
                e.Graphics.FillRectangle(brush, progressBarX, progressBarY, fillWidth, progressBarHeight);

                brush0.Dispose();
                brush.Dispose();
            }
            else
            {
                e.DrawDefault = true;
            }
         ///////https://stackoverflow.com/questions/39181805/accessing-progressbar-in-listview
        }
    }
}


