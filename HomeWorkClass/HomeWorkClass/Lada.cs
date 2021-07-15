using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkClass
{
    class Lada : Car
    {
        private string _prop;
        public Lada(string type) : base("Лада", type, "Скорочено від Влада")
        {
            _prop = "АБС";
        }
        public override string ToString()
        {
            string str = $"Нууууу.... тут є {_prop}\n";
            str = base.ToString() + str;
            return str;
        }
    }
}
