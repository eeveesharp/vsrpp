using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba8.Storage
{
    public static class HistoryStorage
    {
        public static Journal<Computer> Journal{get; set;}

        public static List<string> History { get; set; }
    }
}
