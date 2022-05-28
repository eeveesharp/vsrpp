using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab8_7
{
    public class Patient : Human
    {
        public string Diagnosis { get; set; }

        public string Recommendations { get; set; }

        public Patient(string diagnosis, string recommendations) : base()
        {
            this.Diagnosis = diagnosis;

            this.Recommendations = recommendations;
        }

        public Patient(string diagnosis) : this(diagnosis, "Постельный режим")
        {
        }

        public Patient() : this("ОРВИ")
        {
        }

        public override string ToString()
        {
            return $"Пациент  ФИО:{SecondName} {FirstName} {ThirdName}";
        }

        public override bool Equals(object obj)
        {
            if (obj is Patient
                && obj != null)
            {
                Patient patient = (Patient)obj;

                if (this.FirstName == patient.FirstName
                    && this.SecondName == patient.SecondName
                    && this.ThirdName == patient.ThirdName
                    && this.Age == patient.Age
                    && this.Diagnosis == patient.Diagnosis
                    && this.Recommendations == patient.Recommendations)
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
            $"Диагноз: {Diagnosis}\n" +
            $"Рекомендации: {Recommendations}";
        }
    }
}
