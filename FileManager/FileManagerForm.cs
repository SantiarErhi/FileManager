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
            ((ListViewPanel)rightPanel).listView.MouseClick += ListView_MouseClick;
            ((TreeViewPanel)leftPanel).GetTreeView().NodeMouseClick += treeViewPanel_NodeMouseClick;
            fileViewSplitContainer.Panel1.Controls.Add(leftPanel);
            fileViewSplitContainer.Panel2.Controls.Add(rightPanel);
            model.OnChangeDirectory += UpdatePathBar;
            model.OnChangeDirectory += UpdateRightPanel;
            model.CurrentDirectory = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
        }

        private void UpButton_Click(object sender, EventArgs e)
        {
            model.CurrentDirectory = Directory.GetParent(model.CurrentDirectory).FullName;
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
            ((ListViewPanel)rightPanel).listView.MouseClick += ListView_MouseClick;
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
            ((ListViewPanel)rightPanel).GetContent(model.CurrentDirectory);
        }
        private void UpdatePathBar()
        {
            pathBar.Text = model.CurrentDirectory;
        }
    }
}
