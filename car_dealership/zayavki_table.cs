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
    public partial class zayavki_table : Form
    {
        applic_inf formapl;
        public zayavki_table()
        {
            InitializeComponent();
            formapl = new applic_inf(this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            adminshow.adminshows();
        }
        public void Display()
        {
            conn.display("select idapplications,id_car,id_users,date from applications", zayavki_datagrid);
        }

        private void zayavki_table_Shown(object sender, EventArgs e)
        {
            Display();
        }

        private void zayavki_table_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void zayavki_datagrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                applic_inf forma = new applic_inf(this);
                forma.Show();
            }
        }
    }
}
