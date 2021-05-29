using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace FileManager
{
    class FileViewModel : IObservable<string>
    {
        private string _currentDirectory;
        private List<IObserver<string>> observers;
        public event Action OnChangeDirectory;
        public string currentDirectory { get { return _currentDirectory; } set
            {
                if (Directory.Exists(value))
                {
                    _currentDirectory = value;
                    if (OnChangeDirectory != null)
                    {
                        OnChangeDirectory.Invoke();
                    }
                }
                else MessageBox.Show("This directory doesn`t exists");

            }
        }
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
        public IDisposable Subscribe(IObserver<string> observer)
        {
            observers.Add(observer);
            return new Unsubscriber(observers, observer);
        }
    }
}
