using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba8
{
    [Serializable]
    public class Notebook : Computer
    {
        public string TypeBattery { get; set; }

        public double WorkHours { get; set; }

        public Notebook(string typeBattery,
            double workHours)
            : base()
        {
            this.TypeBattery = typeBattery;

            this.WorkHours = workHours;
        }

        public Notebook(string typeBattery)
            : this(typeBattery, 8)
        {
        }

        public Notebook()
            : this("LiIon")
        {
        }

        public Notebook(Notebook notebook) : base(notebook)
        {
            TypeBattery = notebook.TypeBattery;

            WorkHours = notebook.WorkHours;
        }

        public override bool Equals(object obj)
        {
            if (obj is Notebook
                && obj != null)
            {
                Notebook tempNotebook = (Notebook)obj;

                if (this.CPU == tempNotebook.CPU
                    && this.GPU == tempNotebook.GPU
                    && this.NumberOfCore == tempNotebook.NumberOfCore
                    && this.NumberOfRAM == tempNotebook.NumberOfRAM
                    && this.TypeBattery == tempNotebook.TypeBattery
                    && this.WorkHours == tempNotebook.WorkHours)
                {
                    return true;
                }
            }

            return false;
        }

        public override string Show()
        {
            string sell = "В наличии";

            if (IsSell)
            {
                sell = "Продан";
            }

            return $"Процессор: {CPU}\n" +
          $"Количество оперативной памяти: {NumberOfRAM}\n" +
          $"Количество ядер: {NumberOfCore}\n" +
          $"Видеокарта: {GPU}\n" +
          $"Тип батареи: {TypeBattery}\n" +
          $"Время работы: {WorkHours}\n" +
          $"Цена с ндс:{PriceWithNds}\n" +
          $"Цена без ндс:{PriceWithoutNds}\n" +
          $"{sell}";
        }

        public override string ToString() => string.Format($"Ноутбук| Процессор: {CPU} " +
            $"Видеокарта: {GPU} " +
            $"Количество оперативной памяти: {NumberOfRAM} " +
            $"Время работы: {WorkHours} " +
            $"Цена: {PriceWithoutNds} " +
            $"Дата изготовления: {GetDate.ToShortDateString()}"
            );


        public static bool operator ==(Notebook comp1, Notebook comp2)
        {
            return comp1.Equals(comp2);
        }

        public static bool operator !=(Notebook comp1, Notebook comp2)
        {
            return !comp1.Equals(comp2);
        }
    }
}
