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
        public user_table()
        {
            InitializeComponent();
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
    }
}
