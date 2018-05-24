using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace HereWeGo
{
    public partial class AdminActions : Form
    {
        public AdminActions(String Name)
        {
            InitializeComponent();
            label1.Text = "Welcome Back "+Name;
        }

        private void Insert_Click(object sender, EventArgs e)
        {

            Insert ins= new Insert();
            ins.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DeleteMovie dm = new DeleteMovie();
            dm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UpdateCustomer uc = new UpdateCustomer();
            uc.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DeleteCustomer dc = new DeleteCustomer();
            dc.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            UpdateMovie um = new UpdateMovie();
            um.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Report r = new Report();
            r.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            OurCustomers oc = new OurCustomers();
            oc.Show();
        }
    }
}
