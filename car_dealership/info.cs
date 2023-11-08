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
    public partial class info : Form
    {
        public info()
        {
            InitializeComponent();
        }

        private void info_Load(object sender, EventArgs e)
        {
            label1.Text = carstore.dt.Rows[carstore.index][1].ToString();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void info_Shown(object sender, EventArgs e)
        {
        }
    }
}
