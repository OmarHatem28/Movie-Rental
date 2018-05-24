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
    public partial class OurCustomers : Form
    {
        public OurCustomers()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string constring = @"Data Source=WARHIT;Initial Catalog=master;Integrated Security=True";
            SqlConnection conDataBase = new SqlConnection(constring);
            conDataBase.Open();
            SqlCommand command = new SqlCommand();
            string query = "select * from CUSTOMER left outer join [dbo].[ORDER] on [dbo].[ORDER].C_SSN = CUSTOMER.C_SSN";
            command.CommandText = query;
            command.Connection = conDataBase;
            command.CommandType = CommandType.Text;

            SqlDataReader reader = command.ExecuteReader();


            SqlDataAdapter da = new SqlDataAdapter(query, "Data Source=WARHIT;Initial Catalog=master;Integrated Security=True");
            DataSet ds = new DataSet();
            da.Fill(ds, "CUSTOMER");
            dataGridView1.DataSource = ds.Tables["CUSTOMER"].DefaultView;

            reader.Close();
            conDataBase.Close();
        }
    }
}
