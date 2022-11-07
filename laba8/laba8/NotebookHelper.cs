using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba8
{
    public class NotebookHelper : IComparer<Notebook>
    {
        public int Compare(Notebook x, Notebook y)
        {
            if (x.WorkHours < y.WorkHours)
                return 1;
            else if (x.WorkHours > y.WorkHours)
                return -1;
            else return 0;
        }
    }
}
