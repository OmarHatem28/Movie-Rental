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
    public partial class rent : Form
    {
        string movies,C_SSN;
        public rent(string wanted,string SSN)
        {
            InitializeComponent();
            movies = wanted;
            C_SSN = SSN;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Intiallize the DB Connection and so
                string constring = @"Data Source=WARHIT;Initial Catalog=master;Integrated Security=True";
                SqlConnection conDataBase = new SqlConnection(constring);
                conDataBase.Open();
                SqlCommand command = new SqlCommand();

                // get number of orders to determine orderID
                command.CommandText = "select count(ORDER_ID) from [dbo].[ORDER]";
                command.Connection = conDataBase;
                command.CommandType = CommandType.Text;
                int affectedRows = command.ExecuteNonQuery();
                SqlDataReader dr = command.ExecuteReader();
                string treatment = "0";
                while (dr.Read())
                {
                    treatment = dr[0].ToString();
                }
                int id = int.Parse(treatment);
                id++;
                dr.Close();
                
                // get the total price

                List<string> chosen = new List<string>();
                string movie = "", main = movies;
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

                string query="select PRICE from MOVIE where ( CODE = ";
                for (int i = 0; i < chosen.Count;i++ )
                {
                    query += chosen[i];
                    if (i + 1 < chosen.Count )
                    {
                        query += " or CODE = ";
                    }
                }
                query += ")";
                command.CommandText = query;
                command.Connection = conDataBase;
                command.CommandType = CommandType.Text;
                try
                {
                    affectedRows = command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                dr = command.ExecuteReader();
                int totalprice = 0;
                while (dr.Read())
                {
                    totalprice += int.Parse(dr[0].ToString());
                }
                dr.Close();

                DateTime takendate = DateTime.Parse(Date.Text);
                DateTime actualreturn = takendate.AddDays(10);

                // update quantity
                for (int i = 0; i < chosen.Count; i ++)
                {
                    command.CommandText = "update MOVIE set QUANTITY = QUANTITY-1 where CODE = " + chosen[i];
                    command.Connection = conDataBase;
                    command.CommandType = CommandType.Text;
                    affectedRows = command.ExecuteNonQuery();
                }
                
                // insert in order
                command.CommandText = "insert into [dbo].[ORDER] values (" + id + ", "+C_SSN+",'"+Date.Text+"','"
                                        + actualreturn + "'," + totalprice + ", 0,0)";
                command.Connection = conDataBase;
                command.CommandType = CommandType.Text;
                affectedRows = command.ExecuteNonQuery();

                // insert in ordered
                for (int i = 0; i < chosen.Count; i++)
                {
                    command.CommandText = "insert into ORDERED values ("+id+","+chosen[i]+")";
                    command.Connection = conDataBase;
                    command.CommandType = CommandType.Text;
                    affectedRows = command.ExecuteNonQuery();
                }
                    
                if (affectedRows > 0)
                {
                    MessageBox.Show("Your Order ID = "+id+"\nTotal Price Is: "+totalprice+
                        "\nPlease Note That Late Submission Will Pay Extra 10$.");
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
