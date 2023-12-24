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
    public partial class admin : Form
    {
        public admin()
        {
            InitializeComponent();
        }

        private void roles_frm_Click(object sender, EventArgs e)
        {
            this.Hide();
            roles frm_roles = new roles();
            frm_roles.Show();
        }

        private void user_frm_Click(object sender, EventArgs e)
        {
            this.Hide();
            user_table frm_user_tab = new user_table();
            frm_user_tab.Show();
        }

        private void auto_frm_Click(object sender, EventArgs e)
        {
            this.Hide();
            auto frm_auto = new auto();
            frm_auto.Show();
        }

        private void photo_au_frm_Click(object sender, EventArgs e)
        {
            this.Hide();
            auto_photo frm_auto_photo = new auto_photo();
            frm_auto_photo.Show();
        }

        private void hist_sale_frm_Click(object sender, EventArgs e)
        {
            this.Hide();
            history_sale frm_history_s = new history_sale();
            frm_history_s.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            type_auto frm_auto_type = new type_auto();
            frm_auto_type.Show();
        }

        private void admin_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            osnova frm_autor = new osnova();
            frm_autor.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void zayavki_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            zayavki_table frm_zayavtable = new zayavki_table();
            frm_zayavtable.Show();
        }
    }
}
