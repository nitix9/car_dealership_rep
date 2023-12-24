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
    public partial class applic_inf : Form
    {
        private readonly zayavki_table _parent;
        public applic_inf(zayavki_table parent)
        {
            InitializeComponent();
            _parent = parent;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы точно хотите отклонить заявку?", "Information", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                string sqlldapl = "DELETE FROM autocar.applications WHERE idapplications="+carstore.dt.Rows[carstore.index][0].ToString()+"";
                MySqlConnection con = conn.GetConnection();
                MySqlCommand cmdtd = new MySqlCommand(sqlldapl, con);
                cmdtd.CommandType = CommandType.Text;
                try
                {
                    cmdtd.ExecuteNonQuery();
                    MessageBox.Show("Заявка откланена!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(sqlldapl + "Заявка не отклонена.\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                con.Close();
            }
            _parent.Display();
        }

        private void applic_inf_Shown(object sender, EventArgs e)
        {
            MySqlConnection con = conn.GetConnection();
            string sql = $"SELECT last_name,name,patronymic,mobile_phone FROM users JOIN applications ON users.id = applications.id_users WHERE applications.id_users = "+carstore.dt.Rows[carstore.index][2].ToString()+ "";
            MySqlDataAdapter adapter = new MySqlDataAdapter(sql, con);
            DataTable Tableappl = new DataTable();
            adapter.Fill(Tableappl);
            last_name.Text =Tableappl.Rows[0]["last_name"].ToString();
            name.Text = Tableappl.Rows[0]["name"].ToString();
            patronymic.Text = Tableappl.Rows[0]["patronymic"].ToString();
            phone.Text = Tableappl.Rows[0]["mobile_phone"].ToString();

            string sqlcar = $"SELECT brand,model,cost FROM cars JOIN applications ON cars.id = applications.id_car WHERE applications.id_car =" + carstore.dt.Rows[carstore.index][1].ToString() + "";
            MySqlDataAdapter adaptercar = new MySqlDataAdapter(sqlcar, con);
            DataTable Tableapplcar = new DataTable();
            adaptercar.Fill(Tableapplcar);
            car_name.Text = Tableapplcar.Rows[0]["brand"].ToString()+" "+ Tableapplcar.Rows[0]["model"].ToString();
            sum.Text = Tableapplcar.Rows[0]["cost"].ToString();
        }

        private void accept_but_Click(object sender, EventArgs e)
        {
            MySqlConnection con = conn.GetConnection();
            string sqlupd = $"UPDATE cars SET sold=0 WHERE cars.id =" + carstore.dt.Rows[carstore.index][1].ToString() + "";

            MySqlCommand cmdupd = new MySqlCommand(sqlupd, con);
            try
            {
                cmdupd.ExecuteNonQuery();
                MessageBox.Show("Заявка принята!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();

            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Возникла ошибка при принятии заявки.\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();

            string sqlins = "INSERT INTO sold_cars VALUES (NULL,"+carstore.dt.Rows[carstore.index][2].ToString()+","+carstore.dt.Rows[carstore.index][1].ToString()+",NULL,NULL)";
            MySqlConnection conins = conn.GetConnection();
            MySqlCommand cmdd1 = new MySqlCommand(sqlins, conins);
            try
            {
                cmdd1.ExecuteNonQuery();
            }
            catch{}
            con.Close();

            string sqlldapldel = "DELETE FROM autocar.applications WHERE idapplications=" + carstore.dt.Rows[carstore.index][0].ToString() + "";
            MySqlConnection condel = conn.GetConnection();
            MySqlCommand cmdtdel = new MySqlCommand(sqlldapldel, condel);
            cmdtdel.CommandType = CommandType.Text;
            try
            {
                cmdtdel.ExecuteNonQuery();
            }
            catch{}
            con.Close();
            _parent.Display();
        }
    }
}
