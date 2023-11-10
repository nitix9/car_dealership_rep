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
    public partial class add_photo : Form
    {
        private readonly auto_photo _parent;
        public string id,way,id_cars;
        public add_photo(auto_photo parent)
        {
            InitializeComponent();
            _parent = parent;
        }
        public void UpdateInfo()
        {
            photolbl.Text = "Обновить фото";
            add_pht.Text = "Обновить";
            waytxt.Text = way;
            idcartxt.Text = id_cars;
        }

        public void SaveInfo()
        {
            photolbl.Text = "Добавить фото";
            add_pht.Text = "Сохранить";
            waytxt.Text = way;
            idcartxt.Text = id_cars;
            Clear();
        }
        public void Clear()
        {
            waytxt.Text=idcartxt.Text = string.Empty;
        }
        private void add_pht_Click(object sender, EventArgs e)
        {
            if (add_pht.Text == "Сохранить")
            {
                Photoidu pht = new Photoidu(waytxt.Text.Trim(), idcartxt.Text.Trim());
                conn.InsertPhoto(pht);
                Clear();
            }
            if (add_pht.Text == "Обновить")
            {
                Photoidu pht = new Photoidu(waytxt.Text.Trim(), idcartxt.Text.Trim());
                conn.UpdatePhoto(pht, id);
                Clear();
            }
            _parent.Display();
        }
    }
}
