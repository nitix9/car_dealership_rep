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
    public partial class history_sale : Form
    {
        add_hist formh;
        public history_sale()
        {
            InitializeComponent();
            formh = new add_hist(this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            admin frm_admin = new admin();
            frm_admin.Show();
        }

        private void history_sale_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        public void Display()
        {
            conn.display("select id,id_users,id_car,date_sale,total_amount from sold_cars", history_datagrid);
        }

        private void history_sale_Shown(object sender, EventArgs e)
        {
            Display();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            formh.Clear();
            formh.SaveInfo();
            formh.ShowDialog();
        }

        private void history_datagrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                formh.Clear();
                formh.id = history_datagrid.Rows[e.RowIndex].Cells[2].Value.ToString();
                formh.id_users = history_datagrid.Rows[e.RowIndex].Cells[3].Value.ToString();
                formh.id_car = history_datagrid.Rows[e.RowIndex].Cells[4].Value.ToString();
                formh.date_sale = history_datagrid.Rows[e.RowIndex].Cells[5].Value.ToString();
                formh.UpdateInfo();
                formh.ShowDialog();
                return;
            }
            if (e.ColumnIndex == 1)
            {
                if (MessageBox.Show("Вы точно хотите удалить запись?", "Information", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    conn.DeleteHistsl(history_datagrid.Rows[e.RowIndex].Cells[2].Value.ToString());
                    Display();
                }
                return;
            }
        }
    }
}
