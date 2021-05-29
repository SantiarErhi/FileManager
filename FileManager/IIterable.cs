using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileManager
{
    interface IIterable<T>
    {
        void MoveNext();
        void MovePrevious();
        bool HasNext();
        bool HasPrevious();
        void Reset();

    }
}
