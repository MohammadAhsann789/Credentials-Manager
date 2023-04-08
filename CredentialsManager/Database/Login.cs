using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace CredentialsManager.Data
{
    public class Login
    {
        SqlConnection con;

        public Login() 
        { 
            con = new SqlConnection();
            con.ConnectionString = ConfigurationManager.ConnectionStrings["DatabaseConnection"].ConnectionString; ;
        }

        public DataTable GetUser_Data(string loginID, string masterKey)
        {
            List<string> values = new List<string>();
            if (con.State != ConnectionState.Open) { con.Open(); }
            string query = "SELECT * FROM Users " +
                "WHERE LoginID = '"+loginID.Trim().ToLower()+"' AND MasterKey = '"+masterKey.Trim()+"';";
            SqlDataAdapter SDA = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            SDA.Fill(dt);
            con.Close();
            return dt;
        }
    }
}
