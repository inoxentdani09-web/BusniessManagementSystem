using Microsoft.Data.SqlClient;
using System.Data;

namespace BusniessManagementSystem.Repositories
{
    public class ReportsComboRepository
    {
        string Connecting_String = "Server=(localdb)\\MSSQLLocalDB;Database=Northwind;Trusted_Connection=True;";

        public DataTable GetReportsCombo()
        {

            string query = "SELECT EmployeeID, LastName + ' ' + FirstName  AS FullName FROM Employees";

            using (SqlConnection conn = new SqlConnection(Connecting_String))
            {
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;

            }
        }

    }
}
