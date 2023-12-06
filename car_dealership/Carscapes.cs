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
using System.Data.SqlClient;

namespace car_dealership
{
    public partial class osnova : Form
    {
        public osnova()
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
                try 
                { 
                    string log_verify = log_box.Text;
                    string pas_verify = pas_box.Text;
                    MySqlConnection con = conn.GetConnection();
                    string sql = $"SELECT mobile_phone,password FROM users WHERE mobile_phone LIKE @mobile_phone AND id_roles=16";
                    MySqlDataAdapter adapter = new MySqlDataAdapter(sql, con);
                    DataTable TableUsers = new DataTable();
                    adapter.SelectCommand.Parameters.Add("@mobile_phone", MySqlDbType.VarChar).Value = log_verify;
                    adapter.Fill(TableUsers);
                    string get_pass = TableUsers.Rows[0]["password"].ToString();
                    bool t2 = BCrypt.Net.BCrypt.Verify(pas_verify, get_pass);            
                    if (t2 == true)
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
                    MessageBox.Show("Неверные данные, вход невозможен", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else if (Admin.Checked==true)
            {
                string log_verify = log_box.Text;
                string pas_verify = pas_box.Text;
                MySqlConnection con = conn.GetConnection();
                string sql = $"SELECT mobile_phone,password FROM users WHERE mobile_phone LIKE @mobile_phone AND id_roles=15";
                MySqlDataAdapter adapter = new MySqlDataAdapter(sql, con);
                DataTable TableUsers = new DataTable();
                adapter.SelectCommand.Parameters.Add("@mobile_phone", MySqlDbType.VarChar).Value = log_verify;
                adapter.Fill(TableUsers);
                string get_pass = TableUsers.Rows[0]["password"].ToString();
                bool t3 = BCrypt.Net.BCrypt.Verify(pas_verify, get_pass);
                try
                {
                    if (t3 == true)
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
            else
            {
                MessageBox.Show("Выберите роль!","Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        internal void Display()
        {
            throw new NotImplementedException();
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

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
