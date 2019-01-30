using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quizzapp
{
    class viewclass
    {
        private string connstring = ConfigurationManager.ConnectionStrings["quiz"].ConnectionString;
        string querry;
        public viewclass(string q)
        {
            this.querry = q;
        }

        public DataTable showrecord()
        {
            DataTable dt = new DataTable();
            SqlConnection conn = new SqlConnection(connstring);
            SqlCommand cmd = new SqlCommand(querry, conn);
            try
            {
                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    dt.Load(dr);
                }


            }
            catch (Exception)
            {
                MessageBox.Show("Brak danych!!");
            }

            finally
            {
                conn.Close();
            }
            return dt;
        }
    }
}
