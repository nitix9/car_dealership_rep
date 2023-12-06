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
    public partial class info : Form
    {
        public info()
        {
            InitializeComponent();
        }

        private void info_Load(object sender, EventArgs e)
        {
            try
            {
                label1.Text = carstore.dt.Rows[carstore.index][2].ToString();
                label2.Text = carstore.dt.Rows[carstore.index][3].ToString();
                label3.Text = carstore.dt.Rows[carstore.index][4].ToString();
                label4.Text = carstore.dt.Rows[carstore.index][5].ToString();
                label5.Text = carstore.dt.Rows[carstore.index][6].ToString();
                label6.Text = carstore.dt.Rows[carstore.index][7].ToString();
                MySqlConnection con = conn.GetConnection();
                string sql = $"SELECT photo_car.way FROM autocar.cars JOIN autocar.photo_car ON photo_car.id_cars = cars.id WHERE cars.id=" + carstore.dt.Rows[carstore.index][0].ToString() + "";
                MySqlDataAdapter adaptway = new MySqlDataAdapter(sql, con);
                DataTable Tableway = new DataTable();
                adaptway.Fill(Tableway);
                pictureBox1.Image = Image.FromFile(Tableway.Rows[0][0].ToString());
                string sqls = $"SELECT COUNT(*) FROM photo_car WHERE id_cars=" + carstore.dt.Rows[carstore.index][0].ToString() + "";
                MySqlCommand cmds = new MySqlCommand(sqls, con);
                int n = Convert.ToInt32(cmds.ExecuteScalar());
                label14.Text = Convert.ToString("из  " + n);
                label13.Text = Convert.ToString(a + 1);
            }
            catch { }
            if (label3.Text == "label3")
            {
                this.Close();
            }
        }
        public int a = 0;

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            a += 1;
            MySqlConnection con = conn.GetConnection();
            string sql = $"SELECT photo_car.way FROM autocar.cars JOIN autocar.photo_car ON photo_car.id_cars = cars.id WHERE cars.id=" + carstore.dt.Rows[carstore.index][0].ToString() + "";
            MySqlDataAdapter adaptway = new MySqlDataAdapter(sql, con);
            DataTable Tableway = new DataTable();
            adaptway.Fill(Tableway);
            if (a == Tableway.Rows.Count)
            {
                a = 0;
                label13.Text = Convert.ToString(a + 3);
            }
            pictureBox1.Image = Image.FromFile(Tableway.Rows[a][0].ToString());
            label13.Text = Convert.ToString(a+1);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            a -= 1;
            MySqlConnection con = conn.GetConnection();
            string sql = $"SELECT photo_car.way FROM autocar.cars JOIN autocar.photo_car ON photo_car.id_cars = cars.id WHERE cars.id=" + carstore.dt.Rows[carstore.index][0].ToString() + "";
            MySqlDataAdapter adaptway = new MySqlDataAdapter(sql, con);
            DataTable Tableway = new DataTable();
            adaptway.Fill(Tableway);
            if (a < 0)
            {
                a = Tableway.Rows.Count-1;
            }
            pictureBox1.Image = Image.FromFile(Tableway.Rows[a][0].ToString());
            label13.Text = Convert.ToString(a+1);
        }
    }
}
