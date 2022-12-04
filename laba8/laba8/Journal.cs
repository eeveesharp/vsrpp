using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba8
{
    public class Journal
    {
        public event EventHandler OnAdd;

        public event EventHandler OnDelete;

        public event EventHandler OnChange;

        public event EventHandler OnSell;

        public List<string> History = new List<string>();
    }
}
