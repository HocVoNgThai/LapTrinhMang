using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Diagnostics;

namespace Lab2
{
    public partial class Bai7 : Form
    {
        public Bai7()
        {
            InitializeComponent();

        }
        private void Bai7_Load(object sender, EventArgs e)
        {

            treeView1.Nodes.Clear();

            // Truy xuẩt các ổ đĩa 
            DriveInfo[] drives = DriveInfo.GetDrives();

            // Thêm các ổ
            foreach (DriveInfo drive in drives)
            {

                {
                    TreeNode treeNode = new TreeNode(drive.Name);
                    treeView1.Nodes.Add(treeNode);

                    // Truy hồi để thêm các folder con
                    Directories(treeNode, drive.RootDirectory);
                }
            }
        }
        private void Directories(TreeNode node, DirectoryInfo dir)
        {
            DirectoryInfo[] dirInfo = dir.GetDirectories();
            foreach (DirectoryInfo Dir in dirInfo)
            {
                try
                {
                    TreeNode treeNode = new TreeNode(Dir.Name);
                    Directories(treeNode, Dir);
                    node.Nodes.Add(treeNode);
                    Files(treeNode, Dir);
                }
                // Để bỏ qua các folder bị lỗi hoăc không truy cập được
                catch (UnauthorizedAccessException ex)
                {
                    //MessageBox.Show($"{ex}");
                }
            }
        }
        private void Files(TreeNode node, DirectoryInfo dir)
        {
            // Thêm các file
            FileInfo[] fileInfo = dir.GetFiles();
            foreach (FileInfo file in fileInfo)
            {
                try
                {
                    TreeNode treeNode = new TreeNode(file.Name);
                    node.Nodes.Add(treeNode);
                }
                catch (UnauthorizedAccessException ex)
                {
                    //MessageBox.Show($"{ex}");
                }
            }
        }
        private void btnOpen_Click(object sender, EventArgs e)
        {
            string address = @treeView1.SelectedNode.FullPath.ToString();
            ProcessStartInfo psi = new ProcessStartInfo()
            {
                FileName = address,
                UseShellExecute = true,
            };
            Process.Start(psi);
            //System.Diagnostics.Process.Start(address);
        }
    }
}
