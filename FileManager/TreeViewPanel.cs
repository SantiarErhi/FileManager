using System;
using System.IO;
using System.Windows.Forms;

namespace FileManager
{
    class TreeViewPanel : FileViewPanel
    {
        bool onlyDirectories;
        TreeView treeView;

        public TreeViewPanel(bool onlyDirectories)
        {
            this.onlyDirectories = onlyDirectories;

        }

        public override void Build()
        {
            Dock = DockStyle.Fill;
            Location = new System.Drawing.Point(133, 28);
            Size = new System.Drawing.Size(667, 397);
            TabIndex = 8;
            treeView = new TreeView();
            this.treeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView.Location = new System.Drawing.Point(0, 28);
            this.treeView.Size = new System.Drawing.Size(133, 397);
            this.treeView.TabIndex = 7;
            treeView.ImageList = ImgList;
            //treeView.BeforeSelect += treeView_BeforeSelect;
            treeView.BeforeExpand += treeView_BeforeExpand;
            BackColor = System.Drawing.Color.Black;
            FillDriveNodes();
            Controls.Add(treeView);

        }

        public TreeView GetTreeView()
        {
            return treeView;
        }
        private void FillDriveNodes()
        {
            try
            {
                foreach (DriveInfo drive in DriveInfo.GetDrives())
                {
                    TreeNode driveNode = new TreeNode { Text = drive.Name,
                        
                    
                    };
                    FillTreeNode(driveNode, drive.Name);
                    treeView.Nodes.Add(driveNode);
                }
            }
            catch (Exception ex) { }
        }
        private void FillTreeNode(TreeNode driveNode, string path)
        {
            try
            {
                driveNode.Nodes.Clear();
                string[] dirs;
                string key;
                string[] split;
                if (onlyDirectories)
                {
                    dirs = Directory.GetDirectories(path);
                    DirectoryInfo info = new DirectoryInfo(path);
                }
                else
                {
                    dirs = Directory.GetFileSystemEntries(path);
                }
                foreach (string dir in dirs)
                {
                    TreeNode dirNode = new TreeNode();
                    if (Directory.Exists(dir))
                    {
                       
                        dirNode.Text = dir.Remove(0, dir.LastIndexOf("\\") + 1);
                        dirNode.ImageKey = "folder";
                            dirNode.Nodes.Add(new TreeNode());

                    }
                    else
                    {
                        dirNode.Text = dir.Remove(0, dir.LastIndexOf("\\") + 1);
                        split = dirNode.Text.Split('.');
                        key = split[split.Length - 1];
                        if (ImgList.Images.ContainsKey(key))
                        {
                            
                            dirNode.ImageKey = key;
                        }
                        else
                            dirNode.ImageKey = "file";
                    }

                    driveNode.Nodes.Add(dirNode);
                }
            }
            catch (Exception ex) {  }
        }
        private void treeView_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            FillTreeNode(e.Node, e.Node.FullPath);

        }
    }
}
