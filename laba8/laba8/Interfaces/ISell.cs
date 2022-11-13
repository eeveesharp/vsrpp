using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba8
{
    public interface ISell
    {
        DateTime DateSell { get; set; }

        bool IsSell { get; set; }

        string Owner { get; set; }

        void Sell();
    }
}
