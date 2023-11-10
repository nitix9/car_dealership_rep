using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace car_dealership
{
    public partial class add_car : Form
    {
        private readonly auto _parent;
        public string id,number,brand,model,year_release,id_types,cost,discription ;
        public add_car(auto parent)
        {
            InitializeComponent();
            _parent = parent;
        }
        public void UpdateInfo()
        {
            lblacar.Text = "Обновить машину";
            add_cars.Text = "Обновить";
            numbertxt.Text = number;
            brandtxt.Text = brand;
            modeltxt.Text = model;
            yearrlstxt.Text = year_release;
            typesidtxt.Text = id_types;
            costtxt.Text = cost;
            disctxt.Text = discription;
        }
        public void SaveInfo()
        {
            lblacar.Text = "Добавить машину";
            add_cars.Text = "Сохранить";
            numbertxt.Text = number;
            brandtxt.Text = brand;
            modeltxt.Text = model;
            yearrlstxt.Text = year_release;
            typesidtxt.Text = id_types;
            costtxt.Text = cost;
            disctxt.Text = discription;
            Clear();
        }
        public void Clear()
        {
            numbertxt.Text = brandtxt.Text = modeltxt.Text = yearrlstxt.Text = typesidtxt.Text = costtxt.Text= disctxt.Text = string.Empty;
        }

        private void add_cars_Click(object sender, EventArgs e)
        {
            if (add_cars.Text == "Сохранить")
            {
                Caridu car = new Caridu(numbertxt.Text.Trim(), brandtxt.Text.Trim(), modeltxt.Text.Trim(), yearrlstxt.Text.Trim(),typesidtxt.Text.Trim(), costtxt.Text.Trim(),disctxt.Text.Trim());
                conn.InsertCar(car);
                Clear();
            }
            if (add_cars.Text == "Обновить")
            {
                Caridu car = new Caridu(numbertxt.Text.Trim(), brandtxt.Text.Trim(), modeltxt.Text.Trim(), yearrlstxt.Text.Trim(), typesidtxt.Text.Trim(), costtxt.Text.Trim(), disctxt.Text.Trim());
                conn.UpdateCar(car,id);
                Clear();
            }
            _parent.Display();
        }
    }
}
