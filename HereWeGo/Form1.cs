using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;

namespace HereWeGo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Admin f2 = new HereWeGo.Admin();
            f2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CustomerLogin c = new CustomerLogin();
            c.Show();
        }
    }
}
