namespace lab4_forms
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
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            selectToolStripMenuItem = new ToolStripMenuItem();
            cancelToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            splitContainer1 = new SplitContainer();
            buttonSelect = new Button();
            treeView = new TreeView();
            tabControl = new TabControl();
            tabDetails = new TabPage();
            labelLastChange = new Label();
            labelSubdirs = new Label();
            labelFiles = new Label();
            labelItems = new Label();
            labelSize = new Label();
            labelFullPath = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            tabCharts = new TabPage();
            statusStrip1 = new StatusStrip();
            ProgressBar = new ToolStripProgressBar();
            backgroundWorker = new System.ComponentModel.BackgroundWorker();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            tabControl.SuspendLayout();
            tabDetails.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, helpToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(784, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { selectToolStripMenuItem, cancelToolStripMenuItem, exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // selectToolStripMenuItem
            // 
            selectToolStripMenuItem.Name = "selectToolStripMenuItem";
            selectToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.S;
            selectToolStripMenuItem.Size = new Size(150, 22);
            selectToolStripMenuItem.Text = "Select";
            selectToolStripMenuItem.Click += selectToolStripMenuItem_Click;
            // 
            // cancelToolStripMenuItem
            // 
            cancelToolStripMenuItem.Name = "cancelToolStripMenuItem";
            cancelToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.T;
            cancelToolStripMenuItem.Size = new Size(150, 22);
            cancelToolStripMenuItem.Text = "Cancel";
            cancelToolStripMenuItem.Click += cancelToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.ShortcutKeys = Keys.Alt | Keys.F4;
            exitToolStripMenuItem.Size = new Size(150, 22);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { aboutToolStripMenuItem });
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(44, 20);
            helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(107, 22);
            aboutToolStripMenuItem.Text = "About";
            // 
            // splitContainer1
            // 
            splitContainer1.AllowDrop = true;
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 24);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(buttonSelect);
            splitContainer1.Panel1.Controls.Add(treeView);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(tabControl);
            splitContainer1.Size = new Size(784, 387);
            splitContainer1.SplitterDistance = 261;
            splitContainer1.TabIndex = 1;
            // 
            // buttonSelect
            // 
            buttonSelect.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonSelect.Location = new Point(186, 3);
            buttonSelect.Name = "buttonSelect";
            buttonSelect.Size = new Size(75, 23);
            buttonSelect.TabIndex = 1;
            buttonSelect.Text = "Select";
            buttonSelect.UseVisualStyleBackColor = true;
            buttonSelect.Click += buttonSelect_Click;
            // 
            // treeView
            // 
            treeView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            treeView.Location = new Point(0, 32);
            treeView.Name = "treeView";
            treeView.Size = new Size(258, 343);
            treeView.TabIndex = 0;
            treeView.BeforeExpand += treeView_BeforeExpand;
            treeView.BeforeSelect += treeView_BeforeSelect;
            treeView.AfterSelect += treeView_AfterSelect;
            // 
            // tabControl
            // 
            tabControl.Controls.Add(tabDetails);
            tabControl.Controls.Add(tabCharts);
            tabControl.Dock = DockStyle.Fill;
            tabControl.Location = new Point(0, 0);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(519, 387);
            tabControl.TabIndex = 0;
            // 
            // tabDetails
            // 
            tabDetails.Controls.Add(labelLastChange);
            tabDetails.Controls.Add(labelSubdirs);
            tabDetails.Controls.Add(labelFiles);
            tabDetails.Controls.Add(labelItems);
            tabDetails.Controls.Add(labelSize);
            tabDetails.Controls.Add(labelFullPath);
            tabDetails.Controls.Add(label6);
            tabDetails.Controls.Add(label5);
            tabDetails.Controls.Add(label4);
            tabDetails.Controls.Add(label3);
            tabDetails.Controls.Add(label2);
            tabDetails.Controls.Add(label1);
            tabDetails.Location = new Point(4, 24);
            tabDetails.Name = "tabDetails";
            tabDetails.Padding = new Padding(3);
            tabDetails.Size = new Size(511, 359);
            tabDetails.TabIndex = 0;
            tabDetails.Text = "Details";
            tabDetails.UseVisualStyleBackColor = true;
            // 
            // labelLastChange
            // 
            labelLastChange.AutoSize = true;
            labelLastChange.Location = new Point(124, 95);
            labelLastChange.Name = "labelLastChange";
            labelLastChange.Size = new Size(0, 15);
            labelLastChange.TabIndex = 11;
            // 
            // labelSubdirs
            // 
            labelSubdirs.AutoSize = true;
            labelSubdirs.Location = new Point(124, 80);
            labelSubdirs.Name = "labelSubdirs";
            labelSubdirs.Size = new Size(0, 15);
            labelSubdirs.TabIndex = 10;
            // 
            // labelFiles
            // 
            labelFiles.AutoSize = true;
            labelFiles.Location = new Point(124, 65);
            labelFiles.Name = "labelFiles";
            labelFiles.Size = new Size(0, 15);
            labelFiles.TabIndex = 9;
            // 
            // labelItems
            // 
            labelItems.AutoSize = true;
            labelItems.Location = new Point(124, 50);
            labelItems.Name = "labelItems";
            labelItems.Size = new Size(0, 15);
            labelItems.TabIndex = 8;
            // 
            // labelSize
            // 
            labelSize.AutoSize = true;
            labelSize.Location = new Point(124, 35);
            labelSize.Name = "labelSize";
            labelSize.Size = new Size(0, 15);
            labelSize.TabIndex = 7;
            // 
            // labelFullPath
            // 
            labelFullPath.AutoSize = true;
            labelFullPath.Location = new Point(124, 20);
            labelFullPath.Name = "labelFullPath";
            labelFullPath.Size = new Size(0, 15);
            labelFullPath.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(14, 95);
            label6.Name = "label6";
            label6.Size = new Size(75, 15);
            label6.TabIndex = 5;
            label6.Text = "Last Change:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(14, 80);
            label5.Name = "label5";
            label5.Size = new Size(49, 15);
            label5.TabIndex = 4;
            label5.Text = "Subdirs:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(14, 65);
            label4.Name = "label4";
            label4.Size = new Size(33, 15);
            label4.TabIndex = 3;
            label4.Text = "Files:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 50);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 2;
            label3.Text = "Items:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 35);
            label2.Name = "label2";
            label2.Size = new Size(30, 15);
            label2.TabIndex = 1;
            label2.Text = "Size:";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 20);
            label1.Name = "label1";
            label1.Size = new Size(56, 15);
            label1.TabIndex = 0;
            label1.Text = "Full Path:";
            // 
            // tabCharts
            // 
            tabCharts.Location = new Point(4, 24);
            tabCharts.Name = "tabCharts";
            tabCharts.Padding = new Padding(3);
            tabCharts.Size = new Size(511, 359);
            tabCharts.TabIndex = 1;
            tabCharts.Text = "Charts";
            tabCharts.UseVisualStyleBackColor = true;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { ProgressBar });
            statusStrip1.Location = new Point(0, 389);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(784, 22);
            statusStrip1.TabIndex = 2;
            statusStrip1.Text = "statusStrip1";
            // 
            // ProgressBar
            // 
            ProgressBar.Maximum = 100000;
            ProgressBar.Name = "ProgressBar";
            ProgressBar.Size = new Size(100, 16);
            // 
            // backgroundWorker
            // 
            backgroundWorker.WorkerReportsProgress = true;
            backgroundWorker.WorkerSupportsCancellation = true;
            backgroundWorker.DoWork += backgroundWorker_DoWork;
            backgroundWorker.ProgressChanged += backgroundWorker_ProgressChanged;
            backgroundWorker.RunWorkerCompleted += backgroundWorker_RunWorkerCompleted;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 411);
            Controls.Add(statusStrip1);
            Controls.Add(splitContainer1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            MinimumSize = new Size(800, 450);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Disk Space Analizer";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            tabControl.ResumeLayout(false);
            tabDetails.ResumeLayout(false);
            tabDetails.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem selectToolStripMenuItem;
        private ToolStripMenuItem cancelToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private SplitContainer splitContainer1;
        private Button buttonSelect;
        private TreeView treeView;
        private StatusStrip statusStrip1;
        private TabControl tabControl;
        private TabPage tabDetails;
        private TabPage tabCharts;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label labelLastChange;
        private Label labelSubdirs;
        private Label labelFiles;
        private Label labelItems;
        private Label labelSize;
        private Label labelFullPath;
        private ToolStripProgressBar ProgressBar;
        private System.ComponentModel.BackgroundWorker backgroundWorker;
    }
}