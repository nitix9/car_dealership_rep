using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace car_dealership
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void log_but_Click(object sender, EventArgs e)
        {
            if (user.Checked == true)
            {
                string log_verify = log_box.Text;
                string pas_verify = pas_box.Text;
                MySqlConnection con = conn.GetConnection();
                string sql = $"SELECT mobile_phone,password FROM users WHERE mobile_phone LIKE @mobile_phone AND password LIKE @password AND id_roles=1";
                MySqlCommand cmd1 = new MySqlCommand(sql, con);
                cmd1.Parameters.Add("@mobile_phone", MySqlDbType.VarChar).Value = log_verify;
                cmd1.Parameters.Add("@password", MySqlDbType.VarChar).Value = pas_verify;
                try
                {
                    object passw_verify = cmd1.ExecuteScalar();
                    if (passw_verify != null)
                    {
                        MessageBox.Show("Успешно", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Hide();
                        user frm_user = new user();
                        frm_user.Show();
                    }
                    else
                    {
                        MessageBox.Show("Неверные данные, вход невозможен", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }    
                }
                catch
                {

                }

            }
            else if (Admin.Checked==true)
            {
                string log_verify = log_box.Text;
                string pas_verify = pas_box.Text;
                MySqlConnection con = conn.GetConnection();
                string sql = $"SELECT mobile_phone,password FROM users WHERE mobile_phone LIKE @mobile_phone AND password LIKE @password AND id_roles=2";
                MySqlCommand cmd1 = new MySqlCommand(sql, con);
                cmd1.Parameters.Add("@mobile_phone", MySqlDbType.VarChar).Value = log_verify;
                cmd1.Parameters.Add("@password", MySqlDbType.VarChar).Value = pas_verify;
                try
                {
                    object passw_verify = cmd1.ExecuteScalar();
                    if (passw_verify != null)
                    {
                        MessageBox.Show("Успешно", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Hide();
                        admin frm_admin = new admin();
                        frm_admin.Show();
                    }
                    else
                    {
                        MessageBox.Show("Неверные данные, вход невозможен", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch
                {

                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pas_box.UseSystemPasswordChar = true;
            hidepas.Visible = false;
        }

        private void showpas_Click(object sender, EventArgs e)
        {
            pas_box.UseSystemPasswordChar = false;
            showpas.Visible = false;
            hidepas.Visible = true;
        }

        private void hidepas_Click(object sender, EventArgs e)
        {
            pas_box.UseSystemPasswordChar = true;
            showpas.Visible = true;
            hidepas.Visible = false;
        }

        private void registration_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            registration frm_registr = new registration();
            frm_registr.Show();
            this.Hide();
        }
    }
}
