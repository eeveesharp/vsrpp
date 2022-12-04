using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba8
{
    public class Journal<T> : List<T>
    {
        public event MyDelegate OnAdd;

        public delegate void MyDelegate(T item);

        public new void Add(T computer)
        {
            if (null != OnAdd)
            {
                OnAdd(computer);
            }

            base.Add(computer);
        }


        public event MyDelegate OnRemove;

        public new void Remove(T computer)
        {
            if (null != OnRemove)
            {
                OnRemove(computer);
            }

            base.Remove(computer);
        }
        public event MyDelegate OnChange;

        public void Change(T computer)
        {
            if (null != OnChange)
            {
                OnChange(computer);
            }
        }

        public event MyDelegate OnSell;

        public void Sell(T computer)
        {
            if (null != OnSell)
            {
                OnSell(computer);
            }
        }
    }
}
