using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace car_dealership
{
    class Histidu
    {
        public string Id_users { get; set; }
        public string Id_car { get; set; }
        public string Date_sale { get; set; }

        public Histidu(string id_users, string id_car, string date_sale)
        {
            Id_users = id_users;
            Id_car = id_car;
            Date_sale = date_sale;
        }
    }
}
