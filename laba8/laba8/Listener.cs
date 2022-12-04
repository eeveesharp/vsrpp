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
        public static void Add(object sender, Computer e)
        {
            string str = $"Добавлен элемент :{e.ToString()}";

            HistoryStorage.History.Add(str);
        }

        public static void Delete(object sender, Computer e)
        {
            string str = $"Удален элемент: {e.ToString()}";

            HistoryStorage.History.Add(str);
        }

        public static void Change(object sender, Computer e)
        {
            string str = "Изменен";

            HistoryStorage.History.Add(str);
        }

        public static void Sell(object sender, Computer e)
        {
            string str = $"Продан элемент: {e.ToString()}";

            HistoryStorage.History.Add(str);
        }
    }
}
