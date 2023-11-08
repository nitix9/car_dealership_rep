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
    public partial class add_user : Form
    {
        private readonly user_table _parent;
        public string id, last_name,name,patronymic,adress,mobile_phone,password,id_roles;

        public add_user(user_table parent)
        {
            InitializeComponent();
            _parent = parent;
        }
        public void UpdateInfo()
        {
            label2.Text = "Обновить роль";
            add_userrs.Text = "Обновить";
            last_nametxt.Text = last_name;
            nametxt.Text = name;
            patronymictxt.Text = patronymic;
            adresstxt.Text = adress;
            phonetxt.Text = mobile_phone;
            pastxt.Visible = false;
            label5.Visible = false;
            irtxt.Text = id_roles;
        }
        public void SaveInfo()
        {
            label2.Text = "Добавить роль";
            add_userrs.Text = "Сохранить";
            last_nametxt.Text = last_name;
            nametxt.Text = name;
            patronymictxt.Text = patronymic;
            adresstxt.Text = adress;
            phonetxt.Text = mobile_phone;
            pastxt.Text = password;
            irtxt.Text = id_roles;
        }
        public void Clear()
        {
            last_nametxt.Text = nametxt.Text = patronymictxt.Text = adresstxt.Text = phonetxt.Text = pastxt.Text = irtxt.Text= string.Empty;
        }
        private void add_userrs_Click(object sender, EventArgs e)
        {
            if (add_userrs.Text == "Сохранить")
            {
                Useridu usr = new Useridu(last_nametxt.Text.Trim(), nametxt.Text.Trim(), patronymictxt.Text.Trim(), adresstxt.Text.Trim(), phonetxt.Text.Trim(), pastxt.Text.Trim(), irtxt.Text.Trim());
                conn.InsertUser(usr);
                Clear();
            }
            if (add_userrs.Text == "Обновить")
            {
                Useridu usr = new Useridu(last_nametxt.Text.Trim(), nametxt.Text.Trim(), patronymictxt.Text.Trim(), adresstxt.Text.Trim(), phonetxt.Text.Trim(), pastxt.Text.Trim(), irtxt.Text.Trim());
                conn.UpdateUser(usr, id);
                Clear();
            }
            _parent.Display();
        }
    }
}
