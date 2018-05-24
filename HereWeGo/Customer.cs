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
    public partial class Customer : Form
    {
        string C_SSN;
        public Customer(string SSN)
        {
            InitializeComponent();
            C_SSN = SSN;
        }

        private void Customer_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'masterDataSet.MOVIE' table. You can move, or remove it, as needed.

        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<int> chosen = new List<int>();

            for (int i = 0; i <= (Categories.Items.Count - 1); i++)
            {
                if (Categories.GetItemChecked(i))
                {
                    chosen.Add(i+1);
                }
            }
            int radio = 0;
            if (radioButton1.Checked == true)
            {
                radio = 1;
            }
            else if (radioButton2.Checked == true)
            {
                radio = 2;
            }

            string constring = @"Data Source=WARHIT;Initial Catalog=master;Integrated Security=True";
            SqlConnection conDataBase = new SqlConnection(constring);
            conDataBase.Open();
            SqlCommand command = new SqlCommand();
            string query;
            if (chosen.Count > 0)
            {
                query = "select DISTINCT MOVIE.* from MOVIE,IS_A,HAS_A where MovieCode = MOVIE.CODE and Quantity > 0 " +
                    "and MovieCode = HAS_A.CODE and ";
                if (radio != 0)
                {
                    query += "STORE_NUMB=" + radio + " and ";
                }
                query+="(";
                for (int i = 0; i < chosen.Count; i++)
                {
                     query += "TypeID = "+chosen[i];
                     if (i + 1 != chosen.Count)
                     {
                         query += " or ";
                     }
                }
                query += ") ORDER BY CODE";
            }
            else
            {
                query = "select DISTINCT MOVIE.* from MOVIE,HAS_A where Quantity > 0 and MOVIE.CODE = HAS_A.CODE";
                if (radio != 0)
                {
                    query += " and STORE_NUMB=" + radio;
                }
                query += " ORDER BY MOVIE.CODE";
            }
            command.CommandText = query;
            command.Connection = conDataBase;
            command.CommandType = CommandType.Text;

            SqlDataReader reader = command.ExecuteReader();
            

            SqlDataAdapter da = new SqlDataAdapter(query, "Data Source=WARHIT;Initial Catalog=master;Integrated Security=True");
            DataSet ds = new DataSet();
            da.Fill(ds, "MOVIE");
            dataGridView1.DataSource = ds.Tables["MOVIE"].DefaultView;

            reader.Close();
            conDataBase.Close();

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            rent r = new rent(textBox1.Text,C_SSN);
            r.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            returnMovies rm = new returnMovies();
            rm.Show();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
