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
    public partial class type_auto : Form
    {
        add_type formt;
        public type_auto()
        {
            InitializeComponent();
            formt = new add_type(this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            admin frm_admin = new admin();
            frm_admin.Show();
        }

        private void type_auto_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        public void Display()
        {
            conn.display("select id,name_types from types_car", type_datagrid);
        }

        private void type_auto_Shown(object sender, EventArgs e)
        {
            Display();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            formt.Clear();
            formt.SaveInfo();
            formt.ShowDialog();
        }

        private void type_datagrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                formt.Clear();
                formt.id = type_datagrid.Rows[e.RowIndex].Cells[2].Value.ToString();
                formt.name_types = type_datagrid.Rows[e.RowIndex].Cells[3].Value.ToString();
                formt.UpdateInfo();
                formt.ShowDialog();
                return;
            }
            if (e.ColumnIndex == 1)
            {
                if (MessageBox.Show("Вы точно хотите удалить запись?", "Information", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    conn.DeleteType(type_datagrid.Rows[e.RowIndex].Cells[2].Value.ToString());
                    Display();
                }
                return;
            }
        }
    }
}
