using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba8
{
    public class NotebookCollection : IComparer<Notebook>, IEnumerator
    {
        private List<Desktop> _computers;

        int position = -1;

        public object Current
        {
            get
            {
                if (position == -1 || position >= _computers.Count)
                    throw new ArgumentException();
                return _computers[position];
            }
        }

        public NotebookCollection(List<Desktop> computers)
        {
            _computers = computers;
        }

        public int Compare(Notebook x, Notebook y)
        {
            int result = 0;

            if (x.WorkHours < y.WorkHours)
            {
                result = 1;
            }
            else if (x.WorkHours > y.WorkHours)
            {
                result = -1;
            }

            return result;
        }
        public bool MoveNext()
        {
            if (position < _computers.Count - 1)
            {
                position++;
                return true;
            }
            else
                return false;
        }
        public void Reset() => position = -1;
    }
}
