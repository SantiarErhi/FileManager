using System;
using System.Windows.Forms;

namespace FileManager
{
    abstract class FileViewPanel : Panel, IObserver<string>
    {
        protected ImageList ImgList { get; private set; }
        protected FileViewPanel()
        {
            
            ImgList = new ImageList();
            ImgList.Images.Add("folder", Properties.Resources.stock_folder);
            ImgList.Images.Add("txt", Properties.Resources.txt);
            ImgList.Images.Add("doc", Properties.Resources.doc);
            ImgList.Images.Add("docx", Properties.Resources.doc);

            ImgList.Images.Add("pdf", Properties.Resources.pdf);
            ImgList.Images.Add("ppt", Properties.Resources.ppt);
            ImgList.Images.Add("pptx", Properties.Resources.ppt);

            ImgList.Images.Add("zip", Properties.Resources.zip);
            ImgList.Images.Add("mp3", Properties.Resources.mp3);
            ImgList.Images.Add("xls", Properties.Resources.xls);
            ImgList.Images.Add("xlsx", Properties.Resources.xls);
            ImgList.Images.Add("file", Properties.Resources.file);

            ImgList.Images.Add("dll", Properties.Resources.dll);

        }
        public abstract void Build();

        public void OnCompleted()
        {
            throw new NotImplementedException();
        }

        public void OnError(Exception error)
        {
            throw new NotImplementedException();
        }

        public void OnNext(string value)
        {
            throw new NotImplementedException();
        }
    }
}
