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
    public partial class DeleteCustomer : Form
    {
        public DeleteCustomer()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string constring = @"Data Source=WARHIT;Initial Catalog=master;Integrated Security=True";
                SqlConnection conDataBase = new SqlConnection(constring);
                conDataBase.Open();
                SqlCommand command = new SqlCommand();
                command.CommandText = "Delete from CUSTOMER where C_SSN = " + SSN.Text;
                command.Connection = conDataBase;
                command.CommandType = CommandType.Text;
                int affectedRows = command.ExecuteNonQuery();
                if (affectedRows > 0)
                {
                    MessageBox.Show("Success");
                }
                else { MessageBox.Show("Failed"); }

                conDataBase.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            this.Close();
        }
    }
}
