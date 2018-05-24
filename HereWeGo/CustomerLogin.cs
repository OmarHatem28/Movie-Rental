using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HereWeGo
{
    public partial class CustomerLogin : Form
    {
        public CustomerLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string constring = @"Data Source=WARHIT;Initial Catalog=master;Integrated Security=True";
            SqlConnection conDataBase = new SqlConnection(constring);
            conDataBase.Open();
            SqlCommand command = new SqlCommand();

            command.CommandText = "select C_Pass,C_SSN from CUSTOMER";
            command.Connection = conDataBase;
            command.CommandType = CommandType.Text;
            int affectedRows = command.ExecuteNonQuery();
            SqlDataReader dr = command.ExecuteReader();
            string pass = "0";
            while (dr.Read())
            {
                pass = dr[0].ToString();
                if (textBox2.Text == pass )
                {
                    string SSN = dr[1].ToString();
                    Customer c = new Customer(SSN);
                    c.Show();
                    break;
                }
            }
            
            dr.Close();
            conDataBase.Close();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CustomerSignUp c = new CustomerSignUp();
            c.Show();
            this.Close();
        }
    }
}
