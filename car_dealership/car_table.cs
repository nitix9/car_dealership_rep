using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace car_dealership
{
    public partial class auto : Form
    {
        add_car formc;
        public auto()
        {
            InitializeComponent();
            formc = new add_car(this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            adminshow.adminshows();
        }

        private void auto_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        public void Display()
        {
            conn.display("select id,number,brand,model,year_release,id_types,cost,discription from cars", car_datagrid);
        }

        private void auto_Shown(object sender, EventArgs e)
        {
            Display();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            formc.Clear();
            formc.SaveInfo();
            formc.ShowDialog();
        }

        private void car_datagrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                formc.Clear();
                formc.id = car_datagrid.Rows[e.RowIndex].Cells[2].Value.ToString();
                formc.number = car_datagrid.Rows[e.RowIndex].Cells[3].Value.ToString();
                formc.brand = car_datagrid.Rows[e.RowIndex].Cells[4].Value.ToString();
                formc.model = car_datagrid.Rows[e.RowIndex].Cells[5].Value.ToString();
                formc.year_release = car_datagrid.Rows[e.RowIndex].Cells[6].Value.ToString();
                formc.id_types = car_datagrid.Rows[e.RowIndex].Cells[7].Value.ToString();
                formc.cost = car_datagrid.Rows[e.RowIndex].Cells[8].Value.ToString();
                formc.discription = car_datagrid.Rows[e.RowIndex].Cells[9].Value.ToString();
                formc.UpdateInfo();
                formc.ShowDialog();
                return;
            }
            if (e.ColumnIndex == 1)
            {
                if (MessageBox.Show("Вы точно хотите удалить запись?", "Information", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    conn.DeleteCar(car_datagrid.Rows[e.RowIndex].Cells[2].Value.ToString());
                    Display();
                }
                return;
            }
        }
    }
}
