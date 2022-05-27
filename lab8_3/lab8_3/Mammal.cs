using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab8_3
{
    public class Mammal : Animal
    {
        public int NumberOfTeeth { get; set; }

        public double EarLength { get; set; }

        public Mammal(int numberOfTeeth, double earLength) : base()
        {
            NumberOfTeeth = numberOfTeeth;

            EarLength = earLength;
        }

        public Mammal(int numberOfTeeth) : this(numberOfTeeth, 37)
        {
        }

        public Mammal() : this(20)
        {
        }

        public override string Information()
        {
            string info = $"Млекопитающее : {Name}\n" +
            $"Возвраст: {Age}\n" +
            $"Вес: {Weight}\n" +
            $"Кол-во зубов: {NumberOfTeeth}\n" +
            $"Длина ушей: {EarLength}";

            return info;
        }

        public override string ToString()
        {
            return string.Format($"Млекопитающее : {Name}");
        }

        public override bool Equals(object obj)
        {
            if (obj is Mammal
                && obj != null)
            {
                Mammal tempMammal = (Mammal)obj;

                if (this.Name == tempMammal.Name
                    && this.Age == tempMammal.Age
                    && this.Weight == tempMammal.Weight
                    && this.NumberOfTeeth == tempMammal.NumberOfTeeth
                    && this.EarLength == tempMammal.EarLength)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
