using laba8.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba8
{
    public class Listener
    {      
        public static void Add(object sender, EventArgs e)
        {
            string str = "Добавлен";

            HistoryStorage.History.Add(str);
        }

        public static void Delete(object sender, EventArgs e)
        {
            string str = "Удален";

            HistoryStorage.History.Add(str);
        }

        public static void Change(object sender, EventArgs e)
        {
            string str = "Изменен";

            HistoryStorage.History.Add(str);
        }

        public static void Sell(object sender, EventArgs e)
        {
            string str = "Продан";

            HistoryStorage.History.Add(str);
        }
    }
}
