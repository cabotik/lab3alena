using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3a
{
    class TheFelineFamily
    {
        private string type;
        private string typeOfPowerSupply;
        public string Type { get; set; }
        public string TypeOfPowerSupply { get; set; }

        public TheFelineFamily() { }
        public TheFelineFamily(string type) { this.type = type; }
        public TheFelineFamily(string type, string typeOfPowerSupply) { this.type = type; this.typeOfPowerSupply = typeOfPowerSupply; }

        public virtual string Print()
        {
            return $"Тип - {this.type}, тип питания - {this.typeOfPowerSupply}";
        }
    }
}
