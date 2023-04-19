namespace lab4_forms
{
    partial class DalogWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.radioButtonLocalDrivers = new System.Windows.Forms.RadioButton();
            this.radioButtonIndividual = new System.Windows.Forms.RadioButton();
            this.radioButtonFolder = new System.Windows.Forms.RadioButton();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonOk = new System.Windows.Forms.Button();
            this.buttonFolders = new System.Windows.Forms.Button();
            this.textBoxFilePath = new System.Windows.Forms.TextBox();
            this.listView = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.SuspendLayout();
            // 
            // radioButtonLocalDrivers
            // 
            this.radioButtonLocalDrivers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButtonLocalDrivers.AutoSize = true;
            this.radioButtonLocalDrivers.Location = new System.Drawing.Point(12, 12);
            this.radioButtonLocalDrivers.Name = "radioButtonLocalDrivers";
            this.radioButtonLocalDrivers.Size = new System.Drawing.Size(109, 19);
            this.radioButtonLocalDrivers.TabIndex = 0;
            this.radioButtonLocalDrivers.TabStop = true;
            this.radioButtonLocalDrivers.Text = "All Local Drivers";
            this.radioButtonLocalDrivers.UseVisualStyleBackColor = true;
            // 
            // radioButtonIndividual
            // 
            this.radioButtonIndividual.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButtonIndividual.AutoSize = true;
            this.radioButtonIndividual.Location = new System.Drawing.Point(12, 37);
            this.radioButtonIndividual.Name = "radioButtonIndividual";
            this.radioButtonIndividual.Size = new System.Drawing.Size(116, 19);
            this.radioButtonIndividual.TabIndex = 1;
            this.radioButtonIndividual.TabStop = true;
            this.radioButtonIndividual.Text = "Individual Drivers";
            this.radioButtonIndividual.UseVisualStyleBackColor = true;
            // 
            // radioButtonFolder
            // 
            this.radioButtonFolder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButtonFolder.AutoSize = true;
            this.radioButtonFolder.Location = new System.Drawing.Point(12, 172);
            this.radioButtonFolder.Name = "radioButtonFolder";
            this.radioButtonFolder.Size = new System.Drawing.Size(69, 19);
            this.radioButtonFolder.TabIndex = 2;
            this.radioButtonFolder.TabStop = true;
            this.radioButtonFolder.Text = "A Folder";
            this.radioButtonFolder.UseVisualStyleBackColor = true;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.Location = new System.Drawing.Point(397, 225);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 4;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonOk
            // 
            this.buttonOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonOk.Location = new System.Drawing.Point(316, 226);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(75, 23);
            this.buttonOk.TabIndex = 5;
            this.buttonOk.Text = "Ok";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // buttonFolders
            // 
            this.buttonFolders.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonFolders.Location = new System.Drawing.Point(397, 196);
            this.buttonFolders.Name = "buttonFolders";
            this.buttonFolders.Size = new System.Drawing.Size(75, 23);
            this.buttonFolders.TabIndex = 6;
            this.buttonFolders.Text = "...";
            this.buttonFolders.UseVisualStyleBackColor = true;
            this.buttonFolders.Click += new System.EventHandler(this.buttonFolders_Click);
            // 
            // textBoxFilePath
            // 
            this.textBoxFilePath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxFilePath.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.textBoxFilePath.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem;
            this.textBoxFilePath.Location = new System.Drawing.Point(12, 197);
            this.textBoxFilePath.Name = "textBoxFilePath";
            this.textBoxFilePath.Size = new System.Drawing.Size(379, 23);
            this.textBoxFilePath.TabIndex = 7;
            this.textBoxFilePath.TextChanged += new System.EventHandler(this.textBoxFilePath_TextChanged);
            // 
            // listView
            // 
            this.listView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listView.FullRowSelect = true;
            this.listView.Location = new System.Drawing.Point(12, 62);
            this.listView.MultiSelect = false;
            this.listView.Name = "listView";
            this.listView.OwnerDraw = true;
            this.listView.Size = new System.Drawing.Size(460, 104);
            this.listView.TabIndex = 8;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            this.listView.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.listView_ColumnClick);
            this.listView.DrawColumnHeader += new System.Windows.Forms.DrawListViewColumnHeaderEventHandler(this.listView1_DrawColumnHeader);
            this.listView.DrawSubItem += new System.Windows.Forms.DrawListViewSubItemEventHandler(this.listView1_DrawSubItem);
            this.listView.Click += new System.EventHandler(this.listView_Click);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Name";
            this.columnHeader1.Width = 70;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Total";
            this.columnHeader2.Width = 80;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Free";
            this.columnHeader3.Width = 70;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Used/Total";
            this.columnHeader4.Width = 80;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Used/Total";
            this.columnHeader5.Width = 80;
            // 
            // DalogWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 261);
            this.Controls.Add(this.listView);
            this.Controls.Add(this.textBoxFilePath);
            this.Controls.Add(this.buttonFolders);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.radioButtonFolder);
            this.Controls.Add(this.radioButtonIndividual);
            this.Controls.Add(this.radioButtonLocalDrivers);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(500, 300);
            this.Name = "DalogWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Select Disk or Folder";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.DalogWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RadioButton radioButtonLocalDrivers;
        private RadioButton radioButtonIndividual;
        private RadioButton radioButtonFolder;
        private Button buttonCancel;
        private Button buttonOk;
        private Button buttonFolders;
        private TextBox textBoxFilePath;
        private ListView listView;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
    }
}