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
    public partial class roles : Form
    {
        add_role forme;
        public roles()
        {
            InitializeComponent();
            forme = new add_role(this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            admin frm_admin = new admin();
            frm_admin.Show();
        }

        private void roles_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            forme.Clear();
            forme.SaveInfo();
            forme.ShowDialog();
        }
        private void roles_Shown(object sender, EventArgs e)
        {
            Display();
        }

        public void Display()
        {
            conn.display("select id,name from roles", rolesdatagrid);
        }

        private void rolesdatagrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                forme.Clear();
                forme.id= rolesdatagrid.Rows[e.RowIndex].Cells[2].Value.ToString();
                forme.name = rolesdatagrid.Rows[e.RowIndex].Cells[3].Value.ToString();
                forme.UpdateInfo();
                forme.ShowDialog();
                return;
            }
            if (e.ColumnIndex == 1)
            {
                if (MessageBox.Show("Вы точно хотите удалить запись?", "Information", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    conn.DeleteRoles(rolesdatagrid.Rows[e.RowIndex].Cells[2].Value.ToString());
                    Display();
                }
                return;
            }
        }
    }
}
