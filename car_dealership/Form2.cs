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
        public roles()
        {
            InitializeComponent();
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
    }
}
