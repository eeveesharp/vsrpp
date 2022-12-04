using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba8
{
    public class Journal<T>
    {
        public event EventHandler<T> OnAdd;

        public void Create(T computer)
        {
            OnAdd?.Invoke(this, computer);
        }


        public event EventHandler OnDelete;

        public void Delete()
        {
            OnDelete?.Invoke(this, EventArgs.Empty);
        }

        public event EventHandler OnChange;

        //public void Change()
        //{
        //    OnAdd?.Invoke(this, EventArgs.Empty);
        //}

        //public event EventHandler OnSell;

        //public void Sell()
        //{
        //    OnAdd?.Invoke(this, EventArgs.Empty);
        //}
    }
}
