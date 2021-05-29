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
            leftPanel = new TreeViewPanel(true, model);
            rightPanel = new ListViewPanel(model);
            leftPanel.Build();
            rightPanel.Build();
            listViewButton.Click += ListViewButton_Click;
            tileViewButton.Click += TileViewButton_Click;
            detailsViewButton.Click += DetailsViewButton_Click;
            smallIconViewButton.Click += SmallIconViewButton_Click;
            ((ListViewPanel)rightPanel).listView.MouseClick += ListView_MouseClick;
            ((TreeViewPanel)leftPanel).GetTreeView().NodeMouseClick += treeViewPanel_NodeMouseClick;
            fileViewSplitContainer.Panel1.Controls.Add(leftPanel);
            fileViewSplitContainer.Panel2.Controls.Add(rightPanel);
            model.OnChangeDirectory += UpdatePathBar;
            model.OnChangeDirectory += UpdateRightPanel;
            model.currentDirectory = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
        }
        private void ListView_MouseClick(object sender, MouseEventArgs e)
        {
            switch (e.Button)
            {

                case MouseButtons.Left:
                    if (((ListView)sender).SelectedItems.Count > 0)
                    {
                        if (Directory.Exists(model.currentDirectory + @"\" + ((ListView)sender).SelectedItems[0].Text))
                        {
                            model.currentDirectory = model.currentDirectory + @"\" + ((ListView)sender).SelectedItems[0].Text;
                        }
                    }
                    break;

                case MouseButtons.Right:
                    if (((ListView)sender).SelectedItems.Count > 0)
                    {
                        if (Directory.Exists(model.currentDirectory + @"\" + ((ListView)sender).SelectedItems[0].Text))
                        {
                            directoryContextMenu.Show(rightPanel, new System.Drawing.Point(e.X, e.Y));
                        }
                    }

                    break;
            }
        }


        private void ChangeRightPanelView(FileViewPanel panel)
        {
            rightPanel = panel;
            rightPanel.Build();
            fileViewSplitContainer.Panel2.Controls.Clear();
            fileViewSplitContainer.Panel2.Controls.Add(rightPanel);
            UpdateRightPanel();
        }
        private void ListViewButton_Click(object sender, System.EventArgs e)
        {
            ChangeRightPanelView(new ListViewPanel(model));
        }

        private void TileViewButton_Click(object sender, System.EventArgs e)
        {
            ChangeRightPanelView(new TileViewPanel(model));
        }

        private void DetailsViewButton_Click(object sender, System.EventArgs e)
        {
            ChangeRightPanelView(new DetailsViewPanel(model));
        }

        private void SmallIconViewButton_Click(object sender, System.EventArgs e)
        {
            ChangeRightPanelView(new SmallIconViewPanel(model));
        }


        private void treeViewPanel_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            model.currentDirectory = e.Node.FullPath;
        }
        private void UpdateRightPanel()
        {
            ((AbstractListView)rightPanel).GetContent(model.currentDirectory);
        }
        private void UpdatePathBar()
        {
            pathBar.Text = model.currentDirectory;
        }
    }
}
