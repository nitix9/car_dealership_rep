using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient; 

namespace car_dealership
{
    public partial class user : Form
    {
        public user()
        {
            InitializeComponent();
        }

        private void user_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void displayUser() 
        {
            conn.display("select number,brand,model,year_release,id_types,cost from cars", dataGridView1);
        }

        private void user_Shown(object sender, EventArgs e)
        {
            displayUser();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
