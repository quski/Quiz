using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace quizzapp
{
    class returnclass
    {
        private string connstring=ConfigurationManager.ConnectionStrings["quiz"].ConnectionString;

        public string scalarReturn(string q)
        {
            string s;
            SqlConnection con = new SqlConnection(connstring);
            con.Open();
            try
            {
                SqlCommand cmd = new SqlCommand(q, con);
                s = cmd.ExecuteScalar().ToString();
            }
            catch(Exception)
            {
                s = "";
            }
            con.Close();
            return s;
        }
    }
}
