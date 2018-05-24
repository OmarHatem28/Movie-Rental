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
    public partial class returnMovies : Form
    {
        public returnMovies()
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
                
                command.CommandText = "select [RETURN_DATE] from [dbo].[ORDER] where ORDER_ID = "+OrderID.Text;
                command.Connection = conDataBase;
                command.CommandType = CommandType.Text;
                int affectedRows = command.ExecuteNonQuery();
                SqlDataReader dr = command.ExecuteReader();
                string date = "0";
                while (dr.Read())
                {
                    date = dr[0].ToString();
                }
                dr.Close();

                DateTime returndate = DateTime.Parse(date);
                DateTime returned = DateTime.Parse(realReturn.Text);

                int penalty = 0;
                if (returndate.Date < returned.Date)
                {
                    penalty = 10;
                }
                if (penalty > 0)
                {
                    MessageBox.Show("There Is A Penalty for Late Return, Equals to: " + penalty);

                    
                }
                else
                {
                    MessageBox.Show("Thanks For Being a Responsible and a Committed Person.");
                }

                command.CommandText = "update [dbo].[ORDER] set TOTAL_PRICE = TOTAL_PRICE+"+penalty+",PENALTY=" + penalty +
                                            ", RETURNED=1 , RETURN_DATE = '"+ returned +"'where ORDER_ID=" + OrderID.Text;
                command.Connection = conDataBase;
                command.CommandType = CommandType.Text;
                affectedRows = command.ExecuteNonQuery();

                command.CommandText = "select MOVIE.CODE from MOVIE,ORDERED where "+
                                      "ORDERED.CODE = MOVIE.CODE and ORDER_ID = " + OrderID.Text;
                command.Connection = conDataBase;
                command.CommandType = CommandType.Text;
                dr = command.ExecuteReader();
                string code = "0";
                List<string> chosen = new List<string>();
                while (dr.Read())
                {
                    code = dr[0].ToString();
                    chosen.Add(code);                    
                }
                dr.Close();

                for (int i = 0; i < chosen.Count; i++)
                {
                    command.CommandText = "update MOVIE set QUANTITY = QUANTITY+1 where CODE = " + chosen[i];
                    command.Connection = conDataBase;
                    command.CommandType = CommandType.Text;
                    affectedRows = command.ExecuteNonQuery();
                }

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
