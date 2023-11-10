using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace car_dealership
{
    class Caridu
    {
        public string Number { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public string Year_release { get; set; }
        public string Id_types { get; set; }
        public string Cost { get; set; }
        public string Discription { get; set; }

        public Caridu(string number, string brand, string model, string year_release, string id_types, string cost, string discription)
        {
            Number = number;
            Brand = brand;
            Model = model;
            Year_release = year_release;
            Id_types = id_types;
            Cost = cost;
            Discription = discription;
        }
    }
}
