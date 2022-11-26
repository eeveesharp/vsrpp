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
            List<Computer> result = new List<Computer>();

            foreach (var item in ComputerStorage.ComputersList)
            {
                if (item is Notebook)
                {
                    result.Add(item);
                }
            }

            var arrResult = result.ToArray();

            Array.Sort(arrResult, collection);

            return arrResult;
        }

        public static Computer[] SortDesktopByDate(ComputerCollection collection)
        {
            List<Computer> result = new List<Computer>();

            foreach (var item in ComputerStorage.ComputersList)
            {
                if (item is Desktop)
                {
                    result.Add(item);
                }
            }

            var arrResult = result.ToArray();

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
            List<Computer> result = new List<Computer>();

            foreach (var item in ComputerStorage.ComputersList)
            {
                if (item is Desktop)
                {
                    result.Add(item);
                }
            }

            result.Sort();

            return result;
        }

        public static List<Computer> SortNotebookByPrice()
        {
            List<Computer> result = new List<Computer>();

            foreach (var item in ComputerStorage.ComputersList)
            {
                if (item is Notebook)
                {
                    result.Add(item);
                }
            }

            result.Sort();

            return result;
        }

        public static Computer[] SortNotebookByWorkHours(NotebookCollection collection)
        {
            List<Notebook> result = new List<Notebook>();

            foreach (var item in ComputerStorage.ComputersList)
            {
                if (item is Notebook)
                {
                    result.Add((Notebook)item);
                }
            }

            var arrResult = result.ToArray();

            Array.Sort(arrResult, collection);

            return arrResult;
        }

        public static Computer[] SortDesktopByBlockPower(DesktopCollection collection)
        {
            List<Desktop> result = new List<Desktop>();

            foreach (var item in ComputerStorage.ComputersList)
            {
                if (item is Desktop)
                {
                    result.Add((Desktop)item);
                }
            }

            var arrResult = result.ToArray();

            Array.Sort(arrResult, collection);

            return arrResult;
        }
    }
}
