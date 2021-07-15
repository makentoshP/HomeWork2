using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkClass
{
    abstract class Car
    {
        private string _name;
        private string _type;
        private string _uniqueProp;
        private List<string> _custPropList = new List<string>();

        public Car(string name = "Машина", string type = "Тип", string uniqueProp = "Машина без особливостей")
        {
            _name = name;
            _type = type;
            _uniqueProp = uniqueProp;
        }
        public string GetCarInfo()
        {
            string str = $"Автомобіль марки {_name} з типом кузова {_type}\n";
            str += $"Унікальна особливість це {_uniqueProp}\n";
            return str;
        }

        public void AddProp(string property)
        {
            _custPropList.Add(property);
        }

        public override string ToString()
        {
            string str = GetCarInfo();
            foreach (var elem in _custPropList)
            {
                str += $"Також було додано {elem}\n";
            }
            return str;
        }
    }
}
