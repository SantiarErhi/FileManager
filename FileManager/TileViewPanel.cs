namespace FileManager
{
    class TileViewPanel : AbstractListView
    {
        public TileViewPanel(FileViewModel model) : base(model)
        {
            listView.View = System.Windows.Forms.View.Tile;
        }
    }
}
