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

        public void displayUser() 
        {
            conn.display("select number,brand,model,year_release,id_types,cost,discription from cars", dataGridView1);
        }

        private void user_Shown(object sender, EventArgs e)
        {
            displayUser();
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            conn.display("select number,brand,model,year_release,id_types,cost,discription from cars WHERE brand LIKE'%"+ textBox1.Text +"%'", dataGridView1);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            info form = new info();
            form.ShowDialog();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
