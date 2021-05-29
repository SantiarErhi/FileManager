namespace FileManager
{
    class DetailsViewPanel : AbstractListView
    {
        public DetailsViewPanel(FileViewModel model) : base(model)
        {
            listView.View = System.Windows.Forms.View.Details;
        }
    }
}
