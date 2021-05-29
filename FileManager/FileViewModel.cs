using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace FileManager
{
    class FileViewModel : IObservable<string>, IIterable<string>
    {
        private string _currentDirectory;
        private List<string> moveHistory = new List<string>();

        private List<IObserver<string>> observers = new List<IObserver<string>>();

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
        public IDisposable Subscribe(IObserver<string> observer)
        {
            observers.Add(observer);
            return new Unsubscriber(observers, observer);
        }

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

        #region Observer
        private class Unsubscriber : IDisposable
        {
            private List<IObserver<string>> _observers;
            private IObserver<string> _observer;

            public Unsubscriber(List<IObserver<string>> observers, IObserver<string> observer)
            {
                this._observers = observers;
                this._observer = observer;
            }

            public void Dispose()
            {
                if (_observer != null && _observers.Contains(_observer))
                    _observers.Remove(_observer);
            }
        }


        #endregion

    }
}
