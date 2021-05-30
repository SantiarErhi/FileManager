using System;
using System.Windows.Forms;
using System.IO;

namespace FileManager
{
    public partial class FileManagerForm : Form
    {
        FileViewModel model;
        FileViewPanel leftPanel;
        FileViewPanel rightPanel;
        public FileManagerForm()
        {
           InitializeComponent();
            model = new FileViewModel();
            leftPanel = new TreeViewPanel(true);
            rightPanel = new ListViewPanel();
            leftPanel.Build();
            rightPanel.Build();
            listViewButton.Click += ListViewButton_Click;
            tileViewButton.Click += TileViewButton_Click;
            detailsViewButton.Click += DetailsViewButton_Click;
            smallIconViewButton.Click += SmallIconViewButton_Click;
            backButton.Click += BackButton_Click;
            forwardButton.Click += ForwardButton_Click;
            upButton.Click += UpButton_Click;
            refreshButton.Click += RefreshButton_Click;
            fileContextMenu.Items["deleteFile"].Click += ContextFileDelete_Click;
            directoryContextMenu.Items["openFolder"].Click += ContextOpenFolder_Click;
            directoryContextMenu.Items["deleteFolder"].Click += ContextFolderDelete_Click;
            listViewContextMenu.Items["createFolder"].Click += ContextCreateFolder_Click;
            ((ListViewPanel)rightPanel).listView.MouseUp += ListView_MouseUp;
            ((ListViewPanel)rightPanel).listView.MouseClick += ListView_MouseClick;
            ((TreeViewPanel)leftPanel).GetTreeView().NodeMouseClick += treeViewPanel_NodeMouseClick;
            fileViewSplitContainer.Panel1.Controls.Add(leftPanel);
            fileViewSplitContainer.Panel2.Controls.Add(rightPanel);
            model.OnChangeDirectory += UpdatePathBar;
            model.OnChangeDirectory += UpdateRightPanel;
            model.CurrentDirectory = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
        }
        private void ContextCreateFolder_Click(object sender, EventArgs e)
        {
            int counter = 0;
            while(Directory.Exists(model.CurrentDirectory + @"\NewFolder" + $"({counter})"))
            {
                counter++;
            }
            Directory.CreateDirectory(model.CurrentDirectory + @"\NewFolder" + $"({counter})");
            model.Refresh();
        }
        private void ListView_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (((ListViewPanel)rightPanel).listView.SelectedItems.Count == 0)
                {
                    listViewContextMenu.Show(rightPanel, e.Location);
                }
            }
        }

        private void ContextFolderDelete_Click(object sender, EventArgs e)
        {
            if (((ListViewPanel)rightPanel).listView.SelectedItems.Count == 1)
            {
                if (Directory.Exists(model.CurrentDirectory + @"\" + ((ListViewPanel)rightPanel).listView.SelectedItems[0].Text))
                {
                    Directory.Delete(model.CurrentDirectory + @"\" + ((ListViewPanel)rightPanel).listView.SelectedItems[0].Text);
                    model.Refresh();

                }
            }

        }
        private void ContextOpenFolder_Click(object sender, EventArgs e)
        {
            if (((ListViewPanel)rightPanel).listView.SelectedItems.Count == 1)
            {
                if (Directory.Exists(model.CurrentDirectory + @"\" + ((ListViewPanel)rightPanel).listView.SelectedItems[0].Text))
                {

                    model.CurrentDirectory = model.CurrentDirectory + @"\" + ((ListViewPanel)rightPanel).listView.SelectedItems[0].Text;
                }
            }
        }
        private void ContextFileDelete_Click(object sender, EventArgs e)
        {
            if (((ListViewPanel)rightPanel).listView.SelectedItems.Count == 1)
            {
                if (File.Exists(model.CurrentDirectory + @"\" + ((ListViewPanel)rightPanel).listView.SelectedItems[0].Text))
                {
                    File.Delete(model.CurrentDirectory + @"\" + ((ListViewPanel)rightPanel).listView.SelectedItems[0].Text);
                    model.Refresh();

                }
            }
        }
        private void RefreshButton_Click(object sender, EventArgs e)
        {
            model.Refresh();
        }

        private void UpButton_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(Directory.GetParent(model.CurrentDirectory).FullName))
            {
                model.CurrentDirectory = Directory.GetParent(model.CurrentDirectory).FullName;
            }
        }

        private void ForwardButton_Click(object sender, EventArgs e)
        {
            model.MoveNext();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            model.MovePrevious();
        }

        private void ListView_MouseClick(object sender, MouseEventArgs e)
        {
            switch (e.Button)
            {

                case MouseButtons.Left:
                    if (((ListView)sender).SelectedItems.Count > 0)
                    {
                        if (Directory.Exists(model.CurrentDirectory + @"\" + ((ListView)sender).SelectedItems[0].Text))
                        {
                            model.CurrentDirectory = model.CurrentDirectory + @"\" + ((ListView)sender).SelectedItems[0].Text;
                        }
                    }
                    break;

                case MouseButtons.Right:
                    if (((ListView)sender).SelectedItems.Count > 0)
                    {
                        if (Directory.Exists(model.CurrentDirectory + @"\" + ((ListView)sender).SelectedItems[0].Text))
                        {
                            directoryContextMenu.Show(rightPanel, e.Location);
                        }
                        if (File.Exists(model.CurrentDirectory + @"\" + ((ListView)sender).SelectedItems[0].Text))
                        {
                            fileContextMenu.Show(rightPanel, e.Location);
                        }
                    }

                    break;
            }
        }
        private void ListViewButton_Click(object sender, System.EventArgs e)
        {
            ((ListViewPanel)rightPanel).ChangeView(View.List);
        }

        private void TileViewButton_Click(object sender, System.EventArgs e)
        {
            ((ListViewPanel)rightPanel).ChangeView(View.Tile);
        }

        private void DetailsViewButton_Click(object sender, System.EventArgs e)
        {
            ((ListViewPanel)rightPanel).ChangeView(View.Details);
        }

        private void SmallIconViewButton_Click(object sender, System.EventArgs e)
        {
            ((ListViewPanel)rightPanel).ChangeView(View.SmallIcon);
        }


        private void treeViewPanel_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            model.CurrentDirectory = e.Node.FullPath;
        }
        private void UpdateRightPanel()
        {
            ((ListViewPanel)rightPanel).Update(model.CurrentDirectory);
        }
        private void UpdatePathBar()
        {
            pathBar.Text = model.CurrentDirectory;
        }
    }
}
