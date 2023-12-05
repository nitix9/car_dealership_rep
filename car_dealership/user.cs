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
            conn.display("SELECT cars.id,cars.number,cars.brand,cars.model,cars.year_release,types_car.name_types,cars.cost,cars.discription FROM autocar.cars " +
                "JOIN autocar.types_car ON autocar.cars.id_types = autocar.types_car.id", dataGridView1);
        }

        private void user_Shown(object sender, EventArgs e)
        {
            displayUser();
            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            conn.display("select number,brand,model,year_release,id_types,cost,discription from cars WHERE brand LIKE'%" + textBox1.Text + "%'", dataGridView1);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 1)
            {
                zayavki zvkfrm = new zayavki();
                zvkfrm.Show();
            }
            if (e.ColumnIndex == 0)
            {
                carstore.index = e.RowIndex;
                info form = new info();
                form.ShowDialog();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
