using BusniessManagementSystem.Models;
using Microsoft.Data.SqlClient;
using System.Data;

namespace BusniessManagementSystem.Repositories
{
    public class CategoryRepository
    {
        string Conn_String = "Server=(localdb)\\MSSQLLocalDB;Database=Northwind;Trusted_Connection=True;";
        SqlConnection conn = null!;
        Category cat = new Category();
        public bool Insert(Category cat)
        {
            DialogResult result = MessageBox.Show("Save Category", "Save", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (result == DialogResult.OK)
            {

                using (conn = new SqlConnection(Conn_String))
                {
                    conn.Open();
                    string query = "Insert Into dbo.Categories(CategoryName,Description,Picture)Values(@CategoryName, @Descriptipn, @Picture)";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@CategoryName", cat.CategoryName);
                        cmd.Parameters.AddWithValue("@Descriptipn", cat.Descriptipn);
                        cmd.Parameters.Add("@Picture", SqlDbType.VarBinary, -1).Value = (object)cat.Photo ?? DBNull.Value;

                        cmd.ExecuteNonQuery();
                        conn.Close();
                    }
                }
                return true;
            }
            return false;
        }
        public bool Update(Category cat)
        {
            return true;

        }
        public Category Delete(int id)
        {
            return cat;

        }
        public Category GetById(int id)
        {
            return cat;

        }
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
