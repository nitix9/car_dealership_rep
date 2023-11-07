using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace car_dealership
{
    internal class conn
    {
        public static MySqlConnection GetConnection()
        {
            string sql = "datasource=26.176.43.176;port=3306;username=denis;password=123456781;database=autocar";
            MySqlConnection con = new MySqlConnection(sql);
            try
            {
                con.Open();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("MySQL Connection! \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return con;
        }

        public static void display(string qrt, DataGridView dgv) 
        {
            string sql = qrt;

            MySqlConnection con = GetConnection();

            MySqlCommand com = new MySqlCommand(sql, con);

            MySqlDataAdapter adp = new MySqlDataAdapter(com);

            DataTable dt = new DataTable();

            adp.Fill(dt);

            dgv.DataSource = dt;

            con.Close();
        
        }
    }
}
