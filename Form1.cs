using Microsoft.VisualBasic.ApplicationServices;
using System.ComponentModel;
using System.Drawing.Drawing2D;
using System.IO;
using System.Runtime;
using System.Security.Policy;
using System.Xml.Linq;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace lab4_forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        struct dataFolder
        {
            public double Size;
            public int Files;
            public int SubDirs;
            public string LastChange;

            public dataFolder(double size, int files, int sub, string last)
            {
                Size = size;
                Files = files;
                SubDirs = sub;
                LastChange = last;
            }
        }

        private int progressBarSize = 100000;
        private Dictionary<string, dataFolder> foldersData;
        private DalogWindow diagWin;
        private string selectedPath = null;
        private bool isCanceled = false;
        private void buttonSelect_Click(object sender, EventArgs e)
        {
            diagWin = new DalogWindow();
            diagWin.Owner = this;
            diagWin.ShowDialog();
        }


        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }






        private void Form1_Load(object sender, EventArgs e)
        {
            ProgressBar.Maximum = progressBarSize;

            string[] drives = Environment.GetLogicalDrives();

            foldersData = new Dictionary<string, dataFolder>();
            backgroundWorker.RunWorkerAsync();

            foreach (string drive in drives)
            {
                DriveInfo di = new DriveInfo(drive);
                int driveImage;

                switch (di.DriveType)    //set the drive's icon
                {
                    case DriveType.CDRom:
                        driveImage = 3;
                        break;
                    case DriveType.Network:
                        driveImage = 6;
                        break;
                    case DriveType.NoRootDirectory:
                        driveImage = 8;
                        break;
                    case DriveType.Unknown:
                        driveImage = 8;
                        break;
                    default:
                        driveImage = 2;
                        break;
                }

                TreeNode node = new TreeNode(drive.Substring(0, 3), driveImage, driveImage);
                node.Tag = drive;

                if (di.IsReady == true)
                    node.Nodes.Add("...");

                treeView.Nodes.Add(node);
            }
            //https://codehill.com/2013/06/list-drives-and-folders-in-a-treeview-using-c/
        }

        private void treeView_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {


            if (e.Node.Nodes.Count > 0)
            {
                if (e.Node.Nodes[0].Text == "..." && e.Node.Nodes[0].Tag == null)
                {
                    e.Node.Nodes.Clear();

                    //get the list of sub direcotires
                    string[] dirs = Directory.GetDirectories(e.Node.Tag.ToString());

                    DirectoryInfo rootDir = new DirectoryInfo(e.Node.Tag.ToString());
                    TreeNode fileNode = null;
                    if (rootDir.GetFiles().Count() > 3)
                    {
                        fileNode = new TreeNode("<File>");
                        fileNode.Tag = null;
                        e.Node.Nodes.Add(fileNode);

                        foreach (var file in rootDir.GetFiles())
                        {
                            TreeNode fileSubNode = new TreeNode(file.Name);
                            fileSubNode.Tag = file;
                            fileNode.Nodes.Add(fileSubNode);
                        }
                    }
                    else
                    {
                        foreach (var file in rootDir.GetFiles())
                        {
                            TreeNode n = new TreeNode(file.Name, 13, 13);
                            e.Node.Nodes.Add(n);
                        }
                    }

                    foreach (string dir in dirs)
                    {
                        DirectoryInfo di = new DirectoryInfo(dir);
                        TreeNode node = new TreeNode(di.Name, 0, 1);

                        try
                        {
                            //keep the directory's full path in the tag for use later
                            node.Tag = dir;

                            //if the directory has sub directories add the place holder
                            if (di.GetDirectories().Count() > 0)
                                node.Nodes.Add(null, "...", 0, 0);


                            fileNode = null;

                            if (di.GetFiles().Count() > 3)
                            {
                                fileNode = new TreeNode("<File>");
                                fileNode.Tag = null;
                                node.Nodes.Add(fileNode);

                                foreach (var file in di.GetFiles())
                                {
                                    TreeNode fileSubNode = new TreeNode(file.Name);
                                    fileSubNode.Tag = file;
                                    fileNode.Nodes.Add(fileSubNode);
                                }
                            }
                            else
                            {
                                foreach (var file in di.GetFiles())
                                {
                                    TreeNode n = new TreeNode(file.Name, 13, 13);
                                    node.Nodes.Add(n);
                                }

                            }

                        }
                        catch (UnauthorizedAccessException)
                        {
                            //display a locked folder icon
                            node.ImageIndex = 12;
                            node.SelectedImageIndex = 12;
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "DirectoryLister",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        finally
                        {
                            e.Node.Nodes.Add(node);
                        }
                    }

                }
            }
            //////https://stackoverflow.com/questions/35159549/how-to-display-all-files-under-folders-in-treeview

        }
        public void UpdateTreeView(string directoryPath)
        {
            selectedPath = directoryPath;
            treeView.Nodes.Clear();

            DirectoryInfo rootDir = new DirectoryInfo(selectedPath);
            var dirNode = new TreeNode(rootDir.Name);
            dirNode.Tag = rootDir.FullName;

            treeView.Nodes.Add(dirNode);

            try
            {
                if (rootDir.GetDirectories().Count() > 0)
                    dirNode.Nodes.Add(null, "...", 0, 0);

                if (rootDir.GetFiles().Count() > 0)
                    dirNode.Nodes.Add(null, "...", 0, 0);
            }
            catch
            {

            }
        }

        private void selectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            diagWin = new DalogWindow();
            diagWin.Owner = this;
            diagWin.ShowDialog();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            if (backgroundWorker.CancellationPending == true)
            {
                isCanceled = true;
                e.Cancel = true;
                return;
            }
            if (selectedPath != null)
            {
                isCanceled = false;
                //selectedPath = "C:\\Program Files (x86)";// "C:\\Users\\PC\\Desktop";// "C:\\Users\\PC\\Desktop\\sem4\\RPiES";

                var rootDirInfo = new DirectoryInfo(selectedPath);
                List<string> t = new List<string>();
                int n = 1;
                try
                {
                    foreach (var item in rootDirInfo.GetDirectories())
                    {
                        t.Add(item.FullName);
                    }
                    foreach (var item in rootDirInfo.GetFiles())
                    {
                        t.Add(item.FullName);
                    }
                    n = rootDirInfo.GetDirectories().Count() + rootDirInfo.GetFiles().Count();
                }
                catch { }


                int file = 0, subdir = 0;
                double size = 0;
                foldersData.Clear();
                ScanDirectory(rootDirInfo, ref file, ref subdir, ref size, ref n, t);
                if (backgroundWorker.CancellationPending == true)
                {
                    isCanceled = true;
                    e.Cancel = true;
                    return;
                }
                try
                {
                    foldersData[selectedPath] = new dataFolder(size, file, subdir, rootDirInfo.LastWriteTime.ToString());
                }
                catch { }
                backgroundWorker.ReportProgress(100);
            }
            //backgroundWorker.ReportProgress(10);
        }

        private void ScanDirectory(DirectoryInfo dirInfo, ref int fileCount, ref int subdirCount, ref double size, ref int n, List<string> t)
        {
            if (backgroundWorker.CancellationPending == true)
            {
                return;
            }
            try
            {
                if (t.Contains(dirInfo.FullName))
                {
                    backgroundWorker.ReportProgress(progressBarSize / n);
                }
                var dirs = dirInfo.GetDirectories();
                foreach (var dir in dirs)
                {
                    if (backgroundWorker.CancellationPending == true)
                    {
                        return;
                    }
                    ScanDirectory(dir, ref fileCount, ref subdirCount, ref size, ref n, t);
                    subdirCount++;
                    foldersData[dir.FullName] = new dataFolder(size, fileCount, subdirCount, dir.LastWriteTime.ToString());
                    size += (double)foldersData[dir.FullName].Size / (1024 * 1024);
                }

                var files = dirInfo.GetFiles();
                foreach (var file in files)
                {
                    if (backgroundWorker.CancellationPending == true)
                    {
                        return;
                    }
                    fileCount++;
                    size += (double)file.Length / (1024 * 1024);
                    foldersData[file.FullName] = new dataFolder(file.Length, 0, 0, file.LastWriteTime.ToString());
                }


            }
            catch { }
        }

        private void backgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            if (e.ProgressPercentage == 100)
            {
                ProgressBar.Value = progressBarSize;

            }
            else
            {
                ProgressBar.Value += e.ProgressPercentage;
            }
        }


        private void backgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            //cancelToolStripMenuItem.Enabled = false;
            if (selectedPath != null && isCanceled == false)
            {
                try
                {
                    treeView.Enabled = true;
                    labelFullPath.Text = selectedPath;
                    if ((foldersData[selectedPath].Size) > 1000)
                    {
                        labelSize.Text = String.Format("{0:F2}GB", foldersData[selectedPath].Size / 1024);
                    }
                    else
                    {
                        labelSize.Text = String.Format("{0:F2}MB", foldersData[selectedPath].Size);
                    }
                    labelItems.Text = (foldersData[selectedPath].SubDirs + foldersData[selectedPath].Files).ToString();
                    labelFiles.Text = (foldersData[selectedPath].Files).ToString();
                    labelSubdirs.Text = (foldersData[selectedPath].SubDirs).ToString();
                    labelLastChange.Text = foldersData[selectedPath].LastChange;
                }
                catch { }
            }
        }

        private void treeView_BeforeSelect(object sender, TreeViewCancelEventArgs e)
        {
            //cancelToolStripMenuItem.Enabled = true;
            //ProgressBar.Value = 0;
            ////labelFiles.Text = "nope";

            //if (backgroundWorker.IsBusy)
            //{
            //    backgroundWorker.CancelAsync();
            //}
            //while (backgroundWorker.IsBusy)
            //{
            //    Application.DoEvents();
            //}
            //selectedPath = e.Node.Text;

            //backgroundWorker.RunWorkerAsync();
        }

        private void cancelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProgressBar.Value = 0;
            selectedPath = null;
            cancelToolStripMenuItem.Enabled = false;
            isCanceled = true;
            if (backgroundWorker.IsBusy)
            {
                backgroundWorker.CancelAsync();
            }
            while (backgroundWorker.IsBusy)
            {
                Application.DoEvents();
            }
        }

        private void treeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            cancelToolStripMenuItem.Enabled = true;
            ProgressBar.Value = 0;
            //labelFiles.Text = "nope";

            if (backgroundWorker.IsBusy)
            {
                backgroundWorker.CancelAsync();
            }
            while (backgroundWorker.IsBusy)
            {
                Application.DoEvents();
            }
            //selectedPath = e.Node.Text;
            selectedPath = (string)e.Node.Tag;

            backgroundWorker.RunWorkerAsync();
        }
    }
}
