using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkClass
{
    class Opel : Car
    {
        private string _prop;
        public Opel(string type) : base("Опель", type, "Молнія класна")
        {
            _prop = "AC";
        }

        public override string ToString()
        {
            string str = $"Вау, тут є ще й {_prop}\n";
            str = base.ToString() + str;
            return str;
        }
    }
}
