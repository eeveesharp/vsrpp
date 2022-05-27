using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab8_3
{
    public class Bird : Animal
    {
        public string BeakColor { get; set; }

        public double WingLength { get; set; }

        public Bird(string beakColor, double wingLength) : base()
        {
            BeakColor = beakColor;

            WingLength = wingLength;
        }

        public Bird(string beakColor) : this(beakColor, 30)
        {
        }

        public Bird() : this("Желтый")
        {
        }

        public override string Information()
        {
            string info = $"Птица : {Name}\n" +
            $"Возвраст: {Age}\n" +
            $"Вес: {Weight}\n" +
            $"Цвет клюва: {BeakColor}\n" +
            $"Длина крыльев: {WingLength}";

            return info;
        }

        public override string ToString()
        {
            return string.Format($"Птица : {Name}");
        }

        public override bool Equals(object obj)
        {
            if (obj is Bird
                && obj != null)
            {
                Bird tempMammal = (Bird)obj;

                if (this.Name == tempMammal.Name
                    && this.Age == tempMammal.Age
                    && this.Weight == tempMammal.Weight
                    && this.BeakColor == tempMammal.BeakColor
                    && this.WingLength == tempMammal.WingLength)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
