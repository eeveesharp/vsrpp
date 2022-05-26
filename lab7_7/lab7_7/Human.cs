using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab7_7
{
    public class Human
    {
        private string _firstName;

        private string _secondName;

        private string _thirdName;

        private int _age;

        private Gender _gender;

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

        public string Gender
        {
            get
            {
                return _gender.ToString();
            }
            set
            {
                _gender = (Gender)Enum.Parse(typeof(Gender), value);
            }
        }

        public Human(string firstName, string secondName, string thirdName, int age, Gender gender)
        {
            this._firstName = firstName;

            this._secondName = secondName;

            this._thirdName = thirdName;

            this._age = age;

            this._gender = gender;
        }

        public Human(string firstName, string secondName, string thirdName, int age): this(firstName, secondName, thirdName, age, lab7_7.Gender.Мужчина)
        {

        }
        public Human(string firstName, string secondName, string thirdName):this(firstName, secondName, thirdName, 18)
        {

        }
        public Human(string firstName, string secondName):this(firstName, secondName,"Геннадьевич")
        {

        }
        public Human(string firstName): this(firstName,"Тхорев")
        {

        }
        public Human():this("Владислав")
        {

        }

        public override string ToString()
        {
            return $"Имя:{FirstName}\n" +
                $"Фамилия:{SecondName}\n" +
                $"Отчество:{ThirdName}\n" +
                $"Возвраст:{Age}" +
                $"Пол:{Gender}";
        }
    }
}
