using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba8
{
    public class Computer : ISell, IComparable
    {
        private DateTime _date;

        private decimal _price = 100;

        private static int nds = 20;

        public decimal PriceWithNds
        {
            get
            {
                var a = _price + (_price * (decimal)(nds / 100.0));

                return a;
            }
            set
            {
                _price = _price + _price * (nds / 100);
            }
        }

        public decimal PriceWithoutNds
        {
            get
            {
                return _price;
            }
            set
            {
                _price = value;
            }
        }

        public DateTime GetDate
        {
            get => _date;
        }

        public DateTime SetDate
        {
            set => _date = value;
        }

        public int Year
        {
            get => _date.Year;

            set => _date = new DateTime(value, _date.Month, _date.Day, _date.Hour, _date.Hour, _date.Second);
        }

        public string CPU { get; set; }

        public int NumberOfRAM { get; set; }

        public string GPU { get; set; }

        public int NumberOfCore { get; set; }

        public bool IsSell { get; set; }

        public DateTime DateSell { get; set; }

        public string Owner { get; set; }

        public bool this[decimal price]
        {
            get
            {
                if (price > _price)
                {
                    return true;
                }

                return false;
            }
        }

        public Computer(string cpu,
            int numberOfRam,
            string gpu,
            int numberOfCore)
        {
            this.CPU = cpu;

            this.GPU = gpu;

            this.NumberOfCore = numberOfCore;

            this.NumberOfRAM = numberOfRam;
        }

        public Computer(string cpu, int numberOfRam, string gpu) : this(cpu,
           numberOfRam,
           gpu,
           8)
        {

        }

        public Computer(string cpu, int numberOfRam) : this(cpu,
            numberOfRam,
            "nvidia")
        {

        }

        public Computer(string cpu) : this(cpu,
            8)
        {

        }

        public Computer() : this("Intel")
        {

        }

        public Computer(Computer computer)
        {
            CPU = computer.CPU;

            GPU = computer.GPU;

            NumberOfCore = computer.NumberOfCore;

            NumberOfRAM = computer.NumberOfRAM;

            SetDate = computer.GetDate;

            PriceWithoutNds = computer.PriceWithoutNds;

            PriceWithNds = computer.PriceWithoutNds;
        }

        public override bool Equals(object obj)
        {
            if (obj is Computer
                && obj != null)
            {
                Computer tempComputer = (Computer)obj;

                if (this.CPU == tempComputer.CPU
                    && this.GPU == tempComputer.GPU
                    && this.NumberOfCore == tempComputer.NumberOfCore
                    && this.NumberOfRAM == tempComputer.NumberOfRAM)
                {
                    return true;
                }
            }

            return false;
        }

        public virtual string Show() => $"Процессор: {CPU}\n" +
            $"Количество оперативной памяти: {NumberOfRAM}\n" +
            $"Количество ядер: {NumberOfRAM}\n" +
            $"Видеокарта: {GPU}";

        public override string ToString() => string.Format($"{CPU}," +
           $"{NumberOfRAM}," +
           $"{NumberOfRAM}," +
           $"{GPU}");

        public void Sell()
        {
            IsSell = false;
            Owner = "Ivan Ivanov";
            DateSell = DateTime.Now;
        }

        public int CompareTo(object obj)
        {
            if (obj is Computer computer 
                && obj != null)
            {
               
                return PriceWithNds.CompareTo(computer.PriceWithNds);
            }
            else
            {
                throw new ArgumentException("Error");
            }
        }

        public static bool operator == (Computer comp1, Computer comp2)
        {
            return comp1.Equals(comp2);
        }

        public static bool operator != (Computer comp1, Computer comp2)
        {
            return !comp1.Equals(comp2);
        }

        public static bool operator >= (Computer comp1, Computer comp2)
        {
            if ((comp1.Equals(comp2))
                || ((comp1.NumberOfCore >= comp2.NumberOfCore
                || comp1.NumberOfRAM >= comp2.NumberOfRAM)))
            {
                return true;
            }

            return false;
        }

        public static bool operator <= (Computer comp1, Computer comp2)
        {
            if ((comp1.Equals(comp2)
                || ( comp1.NumberOfCore <= comp2.NumberOfCore
                || comp1.NumberOfRAM <= comp2.NumberOfRAM)))
            {
                return true;
            }

            return false;
        }

        public static bool operator > (Computer comp1, Computer comp2)
        {
            if ( ((comp1.NumberOfCore > comp2.NumberOfCore
                || comp1.NumberOfRAM > comp2.NumberOfRAM)))
            {
                return true;
            }

            return false;
        }

        public static bool operator < (Computer comp1, Computer comp2)
        {
            if (((comp1.NumberOfCore < comp2.NumberOfCore
                || comp1.NumberOfRAM < comp2.NumberOfRAM)))
            {
                return true;
            }

            return false;
        }
    }
}
