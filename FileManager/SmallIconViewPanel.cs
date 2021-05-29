namespace FileManager
{
    class SmallIconViewPanel : AbstractListView
    {
        public SmallIconViewPanel(FileViewModel model) : base(model)
        {
            listView.View = System.Windows.Forms.View.SmallIcon;
        }
    }
}
