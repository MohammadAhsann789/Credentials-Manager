using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Runtime.InteropServices;

namespace CredentialsManager.Data
{
    public class Categories
    {
        SqlConnection con;
        DataTable dataTable;
        SqlDataAdapter SDA;

        public Categories()
        {
            con = new SqlConnection();
            con.ConnectionString = ConfigurationManager.ConnectionStrings["DatabaseConnection"].
                ConnectionString;
        }

        public DataTable GetCategories(int userID)
        {
            if(con.State != ConnectionState.Open) { con.Open(); }
            string query = "SELECT CategoryID, Name, CategoryTitle FROM DefaultCategories " +
                "ORDER BY CategoryID DESC;";
            SDA = new SqlDataAdapter(query, con);
            dataTable = new DataTable();
            SDA.Fill(dataTable);

            query = "SELECT CategoryID, Name, CategoryTitle FROM Categories " +
                "WHERE UserID = '"+userID+"'";
            SDA = new SqlDataAdapter(query, con);
            SDA.Fill(dataTable);

            con.Close();
            return dataTable;
        }
    }
}
