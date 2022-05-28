using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab8_7
{
    public class Doctor : Human
    {
        public string Specialization { get; set; }

        public double Wages { get; set; }

        public Doctor(string specialization, double wages) : base()
        {
            this.Specialization = specialization;

            this.Wages = wages;
        }

        public Doctor(string specialization) : this(specialization, 800)
        {
        }

        public Doctor() : this("ЛОР")
        {
        }

        public override string ToString()
        {
            return $"Доктор  ФИО:{SecondName} {FirstName} {ThirdName}";
        }

        public override bool Equals(object obj)
        {
            if (obj is Doctor
                && obj != null)
            {
                Doctor doctor = (Doctor)obj;

                if (this.FirstName == doctor.FirstName
                    && this.SecondName == doctor.SecondName
                    && this.ThirdName == doctor.ThirdName
                    && this.Age == doctor.Age
                    && this.Specialization == doctor.Specialization
                    && this.Wages == doctor.Wages)
                {
                    return true;
                }
            }

            return false;
        }

        public override string GetInfo()
        {
            return $"Имя: {FirstName}\n" +
            $"Фамилия: {SecondName}\n" +
            $"Отчество: {ThirdName}\n" +
            $"Возраст: {Age}\n" +
            $"Специализация: {Specialization}\n" +
            $"Зарплата: {Wages}";
        }
    }
}
