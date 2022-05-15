using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab7
{
    public class Computer
    {
        private Color color; 

        public string CPU { get; set; }

        public string RAM { get; set; }

        public string Color
        {
            get => color.ToString();

            set => color = (Color)Enum.Parse(typeof(Color), value);
        }

        public string GPU { get; set; }

        public Computer(string cpu,
            string ram,
            Color color,
            string gpu)
        {
            this.CPU = cpu;

            this.RAM = ram;

            this.Color = color.ToString();

            this.GPU = gpu;
        }

        public Computer(string cpu, string ram, Color color) : this(cpu,
           ram,
           color,
           "nvidia gtx 3080")
        {

        }

        public Computer(string cpu, string ram) : this(cpu,
            ram,
            lab7.Color.Black)
        {
            
        }

        public Computer(string cpu) : this(cpu,
            "hyperx 16bg")
        {

        }

        public Computer() : this("Intel")
        {

        }
    }
}
