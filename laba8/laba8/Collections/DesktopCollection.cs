using System;
using System.Collections;
using System.Collections.Generic;

namespace laba8
{
    public class DesktopCollection : IComparer<Desktop>, IEnumerator
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

        public DesktopCollection(List<Desktop> computers)
        {
            _computers = computers;
        }

        public int Compare(Desktop x, Desktop y)
        {
            int result = 0;

            if (x.PowerBlock < y.PowerBlock)
            {
                result = 1;
            }
            else if (x.PowerBlock > y.PowerBlock)
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
