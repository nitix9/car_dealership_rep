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
    public partial class auto_photo : Form
    {
        add_photo formp;
        public auto_photo()
        {
            InitializeComponent();
            formp = new add_photo(this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            admin frm_admin = new admin();
            frm_admin.Show();
        }

        private void auto_photo_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        public void Display()
        {
            conn.display("select id,way,id_cars from photo_car", photodatagrid);
        }

        private void auto_photo_Shown(object sender, EventArgs e)
        {
            Display();
        }

        private void addpht_Click(object sender, EventArgs e)
        {
            formp.Clear();
            formp.SaveInfo();
            formp.ShowDialog();
        }

        private void photodatagrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                formp.Clear();
                formp.id = photodatagrid.Rows[e.RowIndex].Cells[2].Value.ToString();
                formp.way = photodatagrid.Rows[e.RowIndex].Cells[3].Value.ToString();
                formp.id_cars = photodatagrid.Rows[e.RowIndex].Cells[4].Value.ToString();
                formp.UpdateInfo();
                formp.ShowDialog();
                return;
            }
            if (e.ColumnIndex == 1)
            {
                if (MessageBox.Show("Вы точно хотите удалить запись?", "Information", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    conn.DeletePhoto(photodatagrid.Rows[e.RowIndex].Cells[2].Value.ToString());
                    Display();
                }
                return;
            }
        }
    }
}
