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
using BCrypt.Net;

namespace car_dealership
{
    public partial class registration : Form
    {
        public registration()
        {
            InitializeComponent();
        }

        private void registration_Load(object sender, EventArgs e)
        {

        }

        private void create_but_Click(object sender, EventArgs e)
        {
           try {
                string reg_last_name = lastt_name.Text;
                string reg_name = namee.Text;
                string reg_patronymic = patronymicc.Text;
                string reg_adress = adresss.Text;
                string reg_phone = phonee.Text;
                string reg_pas = passwordd.Text;
                string pass = BCrypt.Net.BCrypt.HashPassword(reg_pas);
                bool t1 = BCrypt.Net.BCrypt.Verify(reg_pas, pass);
                MySqlConnection con = conn.GetConnection();
                string sql = $"INSERT INTO users (last_name,name,patronymic,adress,mobile_phone,password,id_roles) VALUES (@last_name,@name,@patronymic,@adress,@mobile_phone,@password,1)";
                MySqlCommand cmd2 = new MySqlCommand(sql, con);
                cmd2.Parameters.Add("@last_name", MySqlDbType.VarChar).Value = reg_last_name;
                cmd2.Parameters.Add("@name", MySqlDbType.VarChar).Value = reg_name;
                cmd2.Parameters.Add("@patronymic", MySqlDbType.VarChar).Value = reg_patronymic;
                cmd2.Parameters.Add("@adress", MySqlDbType.VarChar).Value = reg_adress;
                cmd2.Parameters.Add("@mobile_phone", MySqlDbType.VarChar).Value = reg_phone;
                cmd2.Parameters.Add("@password", MySqlDbType.VarChar).Value = pass;
                int number = cmd2.ExecuteNonQuery();
                if (number != 0) { MessageBox.Show("Регистрация успешна", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    roles_table frm_autor = new roles_table();
                    frm_autor.Show();
                }
                else 
                {
                    MessageBox.Show("Заполните все поля", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Error); 
                 }

            }
            catch { }
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();
            roles_table frm_autor = new roles_table();
            frm_autor.Show(); ;
        }

        private void registration_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
