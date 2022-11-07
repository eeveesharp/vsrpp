using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba8
{
    public class DesktopHelper : IComparer<Desktop> 
    {
        public int Compare(Desktop x, Desktop y)
        {
            if (x.PowerBlock < y.PowerBlock)
                return 1;
            else if (x.PowerBlock > y.PowerBlock)
                return -1;
            else return 0;
        }
    }
}
