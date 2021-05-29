﻿using System;
using System.IO;
using System.Windows.Forms;

namespace FileManager
{
    abstract class AbstractListView : FileViewPanel
    {
        internal ListView listView;
        protected AbstractListView(FileViewModel model) : base(model)
        {
            listView = new ListView();
        }
        public override void Build()
        {
            Dock = DockStyle.Fill;
            listView.Dock = DockStyle.Fill;
            listView.Columns.Add("Name", 200);
            listView.SmallImageList = ImgList;
            listView.LargeImageList = ImgList;
            Controls.Add(listView);

        }
        
        public void GetContent(string path)
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
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
