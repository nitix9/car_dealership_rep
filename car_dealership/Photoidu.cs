using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace car_dealership
{
    class Photoidu
    {
        public string Way { get; set; }
        public string Id_cars { get; set; }

        public Photoidu(string way, string id_cars)
        {
            Way = way;
            Id_cars = id_cars;
        }
    }
}
