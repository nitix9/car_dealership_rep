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
            label2.Text = carstore.dt.Rows[carstore.index][2].ToString();
            label3.Text = carstore.dt.Rows[carstore.index][3].ToString();
            label4.Text = carstore.dt.Rows[carstore.index][4].ToString();
            label5.Text = carstore.dt.Rows[carstore.index][5].ToString();
            label6.Text = carstore.dt.Rows[carstore.index][6].ToString();
            
        }

        
    }
}
