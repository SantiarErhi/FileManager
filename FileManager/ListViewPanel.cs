namespace FileManager
{
    class ListViewPanel : AbstractListView
    {
        public ListViewPanel(FileViewModel model) : base(model)
        {
            listView.View = System.Windows.Forms.View.List;
        }
        
    }
}
