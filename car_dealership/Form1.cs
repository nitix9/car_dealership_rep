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

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection con = conn.GetConnection();
            string sql = $"INSERT INTO Types_car (name_types) VALUES ('sedan')";
            MySqlCommand cmd = new MySqlCommand(sql, con);
            int number = cmd.ExecuteNonQuery();
        }
    }
}
