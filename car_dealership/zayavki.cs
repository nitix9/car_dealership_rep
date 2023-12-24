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
    public partial class zayavki : Form
    {
        public zayavki()
        {
            InitializeComponent();
        }

        private void send_Click(object sender, EventArgs e)
        {
            string sqlz = "INSERT INTO applications SELECT NULL," + carstore.dt.Rows[carstore.index][0].ToString() + ",id,NULL FROM users WHERE mobile_phone = @number and users.name = @name and users.last_name = @last_name and users.patronymic = @patronymic";
            MySqlConnection con = conn.GetConnection();
            MySqlCommand cmdt = new MySqlCommand(sqlz, con);
            cmdt.Parameters.Add("@number", MySqlDbType.VarChar).Value = numbertxt.Text;
            cmdt.Parameters.Add("@name", MySqlDbType.VarChar).Value = nametxt.Text;
            cmdt.Parameters.Add("@last_name", MySqlDbType.VarChar).Value = lastntxtbx.Text;
            cmdt.Parameters.Add("@patronymic", MySqlDbType.VarChar).Value = otchtxt.Text;
            try
            {
                int n=cmdt.ExecuteNonQuery();
                if (n != 0)
                {
                    MessageBox.Show("Заявка отправлена!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                        MessageBox.Show("Неверные данные, заявка не отправлена!","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch { MessageBox.Show(sqlz); }
            con.Close();
        }
    }
}
