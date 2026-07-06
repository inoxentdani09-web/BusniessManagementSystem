using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace BusniessManagementSystem.Repositories
{
    public class CategoryRepository
    {
        string Conn_String = "Server=(localdb)\\MSSQLLocalDB;Database=Northwind;Trusted_Connection=True;";
        SqlConnection conn = null!;

        public DataSet GetAll()
        {
            DataSet ds = new DataSet();
            using (conn = new SqlConnection(Conn_String))
            {
                conn.Open();
                string query = "SELECT 0 AS CategoryID, 'Select Category' AS CategoryName Union All Select CategoryID,CategoryName  from dbo.Categories";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(ds);
                    return ds;
                }

            }
        }
    }
}
