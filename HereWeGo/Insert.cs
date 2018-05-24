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
    public partial class Insert : Form
    {
        public Insert()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<string> chosen = new List<string>();
            string movie = "",main=Categories.Text;
            for (int i = 0; i < main.Length; i++)
            {
                if (main[i] == ' ')
                {
                    chosen.Add(movie);
                    movie = "";
                }
                else
                {
                    movie += main[i];
                }
            }
            chosen.Add(movie);

            try
            {
                string constring = @"Data Source=WARHIT;Initial Catalog=master;Integrated Security=True";
                SqlConnection conDataBase = new SqlConnection(constring);
                conDataBase.Open();
                SqlCommand command = new SqlCommand();
                command.CommandText = "SELECT CODE FROM MOVIE ORDER BY CODE DESC";
                command.Connection = conDataBase;
                command.CommandType = CommandType.Text;
                int affectedRows = command.ExecuteNonQuery();
                SqlDataReader dr = command.ExecuteReader();
                string treatment = "0";
                dr.Read();
                treatment = dr[0].ToString();
                int id = int.Parse(treatment);
                id++;
                dr.Close();
                command.CommandText = "insert into MOVIE values(" + id + ", '" + Title.Text + "', "
                                    + Price.Text + ", " + Duration.Text + ", " + Quantity.Text + 
                                    " ) insert into HAS_A values ("+id+","+Store.Text+")";
                command.Connection = conDataBase;
                command.CommandType = CommandType.Text;
                affectedRows = command.ExecuteNonQuery();

                for (int i = 0; i < chosen.Count; i++)
                {
                    int cat = 0;
                    if (chosen[i] == "Action")
                        cat = 1;
                    else if (chosen[i] == "Romance")
                        cat = 2;
                    else if (chosen[i] == "Comedy")
                        cat = 3;
                    else if (chosen[i] == "Drama")
                        cat = 4;
                    else if (chosen[i] == "Horror")
                        cat = 5;
                    else if (chosen[i] == "Animation")
                        cat = 6;
                    command.CommandText = "insert into IS_A values (" + cat + "," + id + ")";
                    command.Connection = conDataBase;
                    command.CommandType = CommandType.Text;
                    affectedRows = command.ExecuteNonQuery();
                }
                if (affectedRows > 0)
                {
                    MessageBox.Show("Success");
                }
                else { MessageBox.Show("Failed"); }

                conDataBase.Close();
            }
            catch (Exception ex )
            {
                Console.WriteLine(ex.Message);
            }
            this.Close();
        }
    }
}
