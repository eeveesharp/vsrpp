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
        public static void Add(Computer e)
        {
            string str = $"{DateTime.Now}-Добавлен элемент :{e.ToString()}";

            HistoryStorage.History.Add(str);

            ComputerStorage.ComputersList.Add(e);
        }

        public static void Delete(Computer e)
        {
            string str = $"{DateTime.Now}-Удален элемент: {e.ToString()}";

            HistoryStorage.History.Add(str);

            ComputerStorage.ComputersList.Remove(e);
        }

        public static void Change(Computer e)
        {
            string str = $"{DateTime.Now}-Изменен элемент: {e.ToString()}";

            HistoryStorage.History.Add(str);
        }

        public static void Sell(Computer e)
        {
            string str = $"{DateTime.Now}-Продан элемент: {e.ToString()}";

            HistoryStorage.History.Add(str);
        }
    }
}
