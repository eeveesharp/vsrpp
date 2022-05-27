using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab8_3
{
    public class Animal
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public double Weight { get; set; }

        public Animal(string name, int age,double weight)
        {
            this.Name = name;

            this.Age = age;

            this.Weight = weight;
        }
        public Animal(string name, int age):this(name, age, 20)
        {

        }

        public Animal(string name):this(name, 12)
        {

        }

        public Animal():this("Волк")
        {

        }

        public override bool Equals(object obj)
        {
            if (obj is Animal
                && obj != null)
            {
                Animal tempAnimal = (Animal)obj;

                if (this.Name == tempAnimal.Name && this.Age == tempAnimal.Age && this.Age == tempAnimal.Age)
                {
                    return true;
                }
            }

            return false;
        }

        public virtual string Information()
        {
            string info = $"Название : {Name}\n" +
            $"Возвраст: {Age}\n" +
            $"Вес: {Weight}\n";

            return info;
        }

        public override string ToString()
        {
            return string.Format($"Название: {Name}");
        }
    }
}
