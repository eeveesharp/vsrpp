using laba8.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba8.Services
{
    public static class SortServices
    {
        public static Computer[] SortNotebookByDate(ComputerCollection collection)
        {
            var arrResult = ComputerStorage.ComputersList.Where(x => x is Notebook).ToArray();

            Array.Sort(arrResult, collection);

            return arrResult;
        }

        public static Computer[] SortDesktopByDate(ComputerCollection collection)
        {
            var arrResult = ComputerStorage.ComputersList.Where(x => x is Desktop).ToArray();

            Array.Sort(arrResult, collection);

            return arrResult;
        }

        public static Computer[] SortAllByDate(ComputerCollection collection)
        {
            var arrResult = ComputerStorage.ComputersList.ToArray();

            Array.Sort(arrResult, collection);

            return arrResult;
        }

        public static List<Computer> SortAllByPrice()
        {
            var list = ComputerStorage.ComputersList;

            list.Sort();

            return list;
        }

        public static List<Computer> SortDesktopByPrice()
        {
            var result = ComputerStorage.ComputersList.Where(x => x is Desktop).ToList();

            result.Sort();

            return result;
        }

        public static List<Computer> SortNotebookByPrice()
        {
            var result = ComputerStorage.ComputersList.Where(x => x is Notebook).ToList();

            result.Sort();

            return result;
        }

        public static Computer[] SortNotebookByWorkHours(NotebookCollection collection)
        {
            var arrResult = ComputerStorage.ComputersList.OfType<Notebook>().ToArray();

            Array.Sort(arrResult, collection);

            return arrResult;
        }

        public static Computer[] SortDesktopByBlockPower(DesktopCollection collection)
        {
            var arrResult = ComputerStorage.ComputersList.OfType<Desktop>().ToArray();

            Array.Sort(arrResult, collection);

            return arrResult;
        }
    }
}
