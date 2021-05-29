using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace FileManager
{
    class FileViewModel : IIterable<string>
    {
        private string _currentDirectory;
        private List<string> moveHistory = new List<string>();

        private int pointer;

        public event Action OnChangeDirectory;
        public string CurrentDirectory
        {
            get { return _currentDirectory; }
            set
            {
                if (Directory.Exists(value))
                {
                    _currentDirectory = value;
                    if (pointer < moveHistory.Count - 1)
                    {
                        moveHistory[pointer + 1] = _currentDirectory;
                        pointer++;
                    }
                    else
                    {
                        moveHistory.Add(_currentDirectory);
                        pointer++;
                    }
                    if (OnChangeDirectory != null)
                    {
                        OnChangeDirectory.Invoke();
                    }
                }
                else MessageBox.Show("This directory doesn`t exists");

            }
        }
        public void Refresh()
        {
            OnChangeDirectory.Invoke();
        }
        public FileViewModel()
        {
            pointer = -1;
        }
        #region Iterator

        public void MoveNext()
        {
            if (HasNext())
            {
                _currentDirectory = moveHistory[pointer+1];
                pointer++;
                OnChangeDirectory.Invoke();

            }
            else
            {
                MessageBox.Show("Has not next item");
            }
        }
        

        public void MovePrevious()
        {
            if (HasPrevious())
            {
                _currentDirectory = moveHistory[--pointer];
                OnChangeDirectory.Invoke();

            }
            else
            {
                MessageBox.Show("Has not previous item");
            }
        }

        public bool HasNext()
        {
            return pointer < moveHistory.Count - 1;
        }

        public bool HasPrevious()
        {
            return pointer > 0;
        }

        public void Reset()
        {
            pointer = 0;
        }
        #endregion

    }
}
