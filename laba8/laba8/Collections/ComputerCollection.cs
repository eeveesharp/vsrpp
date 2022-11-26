using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba8
{
    public class ComputerCollection : IEnumerable, IComparer<Computer>
    {
        private IEnumerable<Computer> _computers;

        public ComputerCollection(IEnumerable<Computer> computers)
        {
            _computers = computers; 
        }

        public int Compare(Computer x, Computer y)
        {
            int result = 0;

            if (x.GetDate < y.GetDate)
            {
                result = 1;
            }
            else if (x.GetDate > y.GetDate)
            {
                result = -1;
            }

            return result;
        }

        public IEnumerator<string> GetEnumerator()
        {
            foreach (var item in _computers)
            {
                yield return item.CPU;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
