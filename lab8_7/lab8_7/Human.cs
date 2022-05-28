using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab8_7
{
    public class Human
    {
        private string _firstName;

        private string _secondName;

        private string _thirdName;

        private int _age;

        public string FirstName
        {
            get
            {
                return _firstName;
            }
            set
            {
                _firstName = value;
            }
        }

        public string SecondName
        {
            get
            {
                return _secondName;
            }
            set
            {
                _secondName = value;
            }
        }

        public string ThirdName
        {
            get
            {
                return _thirdName;
            }
            set
            {
                _thirdName = value;
            }
        }

        public int Age
        {
            get
            {
                return _age;
            }
            set
            {
                if (value < 100 && value > 1)
                {
                    _age = value;
                }
            }
        }

        public Human(string firstName, string secondName, string thirdName, int age)
        {
            this._firstName = firstName;

            this._secondName = secondName;

            this._thirdName = thirdName;

            this._age = age;
        }

        public Human(string firstName, string secondName, string thirdName) : this(firstName, secondName, thirdName, 18)
        {

        }
        public Human(string firstName, string secondName) : this(firstName, secondName, "Геннадьевич")
        {

        }
        public Human(string firstName) : this(firstName, "Тхорев")
        {

        }
        public Human() : this("Владислав")
        {

        }

        public override string ToString()
        {
            return $"Имя:{FirstName}\n" +
                $"Фамилия:{SecondName}\n" +
                $"Отчество:{ThirdName}\n" +
                $"Возвраст:{Age}";
        }

        public override bool Equals(object obj)
        {
            if (obj is Human
                && obj != null)
            {
                Human human = (Human)obj;

                if (this._firstName == human.FirstName
                    && this._secondName == human.SecondName
                    && this._thirdName == human.ThirdName
                    && this._age == human.Age)
                {
                    return true;
                }
            }

            return false;
        }

        public virtual string GetInfo()
        {
            return $"Имя: {_firstName}\n" +
            $"Фамилия: {_secondName}\n" +
            $"Отчество: {_thirdName}\n" +
            $"Возраст: {_age}";
        }
    }
}
