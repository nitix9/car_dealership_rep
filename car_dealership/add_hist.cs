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
    public partial class add_hist : Form
    {
        private readonly history_sale _parent;
        public string id, id_users,id_car,date_sale;
        public add_hist(history_sale parent)
        {
            InitializeComponent();
            _parent = parent;
        }
        public void UpdateInfo()
        {
            histlbl.Text = "Обновить запись о продаже";
            add_histsl.Text = "Обновить";
            idustxt.Text = id_users;
            idcartxt.Text = id_car;
            datestxt.Text = date_sale;
            label4.Visible = true;
            datestxt.Visible = true;
        }
        public void SaveInfo()
        {
            histlbl.Text = "Добавить запись о продаже";
            add_histsl.Text = "Сохранить";
            idustxt.Text = id_users;
            idcartxt.Text = id_car;
            datestxt.Text = date_sale;
            label4.Visible = false;
            datestxt.Visible = false;
            Clear();
        }
        public void Clear()
        {
            idustxt.Text = idcartxt.Text = datestxt.Text  = string.Empty;
        }

        private void add_histsl_Click(object sender, EventArgs e)
        {
            if (add_histsl.Text == "Сохранить")
            {
                Histidu hst = new Histidu(idustxt.Text.Trim(), idcartxt.Text.Trim(), datestxt.Text.Trim());
                conn.InsertHistsl(hst);
                Clear();
            }
            if (add_histsl.Text == "Обновить")
            {
                Histidu hst = new Histidu(idustxt.Text.Trim(), idcartxt.Text.Trim(), datestxt.Text.Trim());
                conn.UpdateHistsl(hst, id);
                Clear();
            }
            _parent.Display();
        }
    }
}
