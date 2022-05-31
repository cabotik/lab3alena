using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3a
{
    class Cats : TheFelineFamily
    {
        private string color;
        private int lifeExpectancy;
        public string Color { get; set; }
        public string LifeExpectancy { get; set; }

        public Cats() : base() { }
        public Cats(string type, string typeOfPowerSupply) : base(type, typeOfPowerSupply) { }

        public Cats(string type, string typeOfPowerSupply, string color) : base(type, typeOfPowerSupply)
        {
            this.color = color;
        }
        public Cats(string type, string typeOfPowerSupply, string color, int lifeExpectancy) : base(type, typeOfPowerSupply)
        {
            this.color = color;
            this.lifeExpectancy = lifeExpectancy;
        }
        public override string Print()
        {
            return $" {base.Print()}, окрас {color}, продолжительность жизни {lifeExpectancy} лет.";
        }
    }
}
