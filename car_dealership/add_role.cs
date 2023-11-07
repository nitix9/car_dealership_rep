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
    public partial class add_role : Form
    {
        private readonly roles _parent;
        public string id, name;

        public add_role(roles parent)
        {
            InitializeComponent();
            _parent = parent;
        }

        public void UpdateInfo()
        {
            label2.Text = "Обновить роль";
            add_roles.Text = "Обновить";
            name_roles.Text = name;
        }
        public void SaveInfo()
        {
            label2.Text = "Добавить роль";
            add_roles.Text = "Сохранить";
            name_roles.Text = name;
        }
        public void Clear()
        {
            name_roles.Text = string.Empty;
        }


        private void add_roles_Click(object sender, EventArgs e)
        {
            if (add_roles.Text == "Сохранить")
            {
                Role rls = new Role(name_roles.Text.Trim());
                conn.InsertRole(rls);
                Clear();
            }
            if (add_roles.Text == "Обновить")
            {
                Role rls = new Role(name_roles.Text.Trim());
                conn.UpdateRole(rls,id);
                Clear();
            }
            _parent.Display();
        }
        
    }
}
