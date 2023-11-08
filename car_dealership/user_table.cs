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
    public partial class user_table : Form
    {
        add_user frm;
        public user_table()
        {
            InitializeComponent();
            frm= new add_user(this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            adminshow.adminshows();
        }

        private void user_table_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        public void Display()
        {
            conn.display("select id,last_name,name,patronymic,adress,mobile_phone,password,id_roles from users", user_datagrid);
        }

        private void user_table_Shown(object sender, EventArgs e)
        {
            Display();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frm.Clear();
            frm.SaveInfo();
            frm.ShowDialog();
        }

        private void user_datagrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                frm.Clear();
                frm.id = user_datagrid.Rows[e.RowIndex].Cells[2].Value.ToString();
                frm.last_name = user_datagrid.Rows[e.RowIndex].Cells[3].Value.ToString();
                frm.name = user_datagrid.Rows[e.RowIndex].Cells[4].Value.ToString();
                frm.patronymic = user_datagrid.Rows[e.RowIndex].Cells[5].Value.ToString();
                frm.adress= user_datagrid.Rows[e.RowIndex].Cells[6].Value.ToString();
                frm.mobile_phone = user_datagrid.Rows[e.RowIndex].Cells[7].Value.ToString();
                frm.password = user_datagrid.Rows[e.RowIndex].Cells[8].Value.ToString();
                frm.id_roles = user_datagrid.Rows[e.RowIndex].Cells[9].Value.ToString();
                frm.UpdateInfo();
                frm.ShowDialog();
                return;
            }
            if (e.ColumnIndex == 1)
            {
                if (MessageBox.Show("Вы точно хотите удалить запись?", "Information", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    conn.DeleteUser(user_datagrid.Rows[e.RowIndex].Cells[2].Value.ToString());
                    Display();
                }
                return;
            }
        }
    }
}
