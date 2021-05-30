using System;
using System.IO;
using System.Windows.Forms;

namespace FileManager
{
    class ListViewPanel : FileViewPanel
    {
        internal ListView listView;
        public ListViewPanel()
        {
            listView = new ListView();

        }
        public void ChangeView(View view)
        {
            listView.View = view;
        }
        public override void Build()
        {
            Dock = DockStyle.Fill;
            listView.Dock = DockStyle.Fill;
            listView.View = View.List;
            listView.Columns.Add("Name", 200);
            listView.SmallImageList = ImgList;
            listView.LargeImageList = ImgList;
            Controls.Add(listView);
        }
        public void Update(string path)
        {
            GetContent(path);
        }
        private void GetContent(string path)
        {
            try
            {
                listView.Items.Clear();
                DirectoryInfo info = new DirectoryInfo(path);
                string key;
                string[] split;

                foreach (var entity in info.GetFileSystemInfos())
                {
                    ListViewItem item = new ListViewItem();
                    item.Text = entity.Name;
                    if (Directory.Exists(entity.FullName))
                    {
                        item.ImageKey = "folder";

                    }
                    else
                    {
                        split = item.Text.Split('.');
                        key = split[split.Length - 1];
                        if (ImgList.Images.ContainsKey(key))
                        {

                            item.ImageKey = key;
                        }
                        else
                            item.ImageKey = "file";
                    }
                    listView.Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
