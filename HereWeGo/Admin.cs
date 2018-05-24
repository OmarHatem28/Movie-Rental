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
    public partial class Admin : Form
    {

        public Admin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string constring = @"Data Source=WARHIT;Initial Catalog=master;Integrated Security=True";
            SqlConnection conDataBase = new SqlConnection(constring);
            conDataBase.Open();
            SqlCommand command = new SqlCommand();

            command.CommandText = "select Pass,NAME from ADMIN";
            command.Connection = conDataBase;
            command.CommandType = CommandType.Text;
            int affectedRows = command.ExecuteNonQuery();
            SqlDataReader dr = command.ExecuteReader();
            string pass = "0";
            while (dr.Read())
            {
                pass = dr[0].ToString();
                if (adminpass.Text == pass)
                {
                    string Name = dr[1].ToString();
                    AdminActions aa = new AdminActions(Name);
                    aa.Show();
                    break;
                }
            }

            dr.Close();
            conDataBase.Close();
            this.Close();
        }
    }
}
