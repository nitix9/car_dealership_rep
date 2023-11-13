using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace car_dealership
{
    class Useridu
    {
        public string Last_Name { get; set; }
        public string Name { get; set; }
        public string Patronymic { get; set; }
        public string Adress { get; set; }
        public string Mobile_Phone { get; set; }
        public string Password { get; set; }
        public string Id_Roles { get; set; }

        public Useridu(string last_name, string name, string patronymic, string adress, string mobile_phone, string password, string id_roles)
        {
            Last_Name = last_name;
            Name = name;
            Patronymic = patronymic;
            Adress = adress;
            Mobile_Phone = mobile_phone;
            Password = password;
            Id_Roles = id_roles;
        }
    }
}
