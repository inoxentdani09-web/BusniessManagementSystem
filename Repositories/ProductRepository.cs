using BusniessManagementSystem.Models;
using Microsoft.Data.SqlClient;
using System.Data;
using System.Text;

namespace BusniessManagementSystem.Repositories
{

    public class ProductRepository
    {

        string Conn_String = "Server=(localdb)\\MSSQLLocalDB;Database=Northwind;Trusted_Connection=True;";
        SqlConnection conn = null!;
        Product pro = new Product();
        public bool Insert(Product pro)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to save this product?", "Confirm Save",
                       MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                using (conn = new SqlConnection(Conn_String))
                {
                    conn.Open();
                    StringBuilder sb = new StringBuilder();
                    sb.AppendLine("INSERT INTO dbo.Products(");
                    sb.AppendLine("ProductName,SupplierID,CategoryID,QuantityPerUnit,UnitPrice,UnitsInStock,UnitsOnOrder,ReorderLevel,Discontinued)");
                    sb.AppendLine("VALUES(");
                    sb.AppendFormat("'{0}',", pro.ProductName);
                    sb.AppendFormat("'{0}',", pro.SupplierID);
                    sb.AppendFormat("'{0}',", pro.CategoryID);
                    sb.AppendFormat("'{0}',", pro.QuantityPerUnit);
                    sb.AppendFormat("'{0}',", pro.UnitPrice);
                    sb.AppendFormat("'{0}',", pro.UnitsInStock);
                    sb.AppendFormat("'{0}',", pro.UnitsOnOrder);
                    sb.AppendFormat("'{0}',", pro.ReorderLevel);
                    sb.AppendFormat("'{0}')", pro.Discontinued);
                    using (SqlCommand cmd = new SqlCommand(sb.ToString(), conn))
                    {
                        int rowEffected = cmd.ExecuteNonQuery();
                        if (rowEffected > 0)
                        {
                            MessageBox.Show("Product saved successfully.", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return true;
                        }
                    }
                }
            }
            return false;
        }
        public bool Update(Product pro)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to update this product?", "Edit Employee", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (result == DialogResult.OK)
            {
                using (conn = new SqlConnection(Conn_String))
                {
                    conn.Open();
                    StringBuilder sb = new StringBuilder();
                    sb.AppendLine("UPDATE dbo.Products SET");
                    sb.AppendLine("ProductName = @ProductName,");
                    sb.AppendLine("SupplierID = @SupplierID,");
                    sb.AppendLine("CategoryID = @CategoryID,");
                    sb.AppendLine("UnitPrice = @UnitPrice,");
                    sb.AppendLine("QuantityPerUnit = @QuantityPerUnit,");
                    sb.AppendLine("UnitsOnOrder = @UnitsOnOrder,");
                    sb.AppendLine("UnitsInStock = @UnitsInStock,");
                    sb.AppendLine("ReorderLevel = @ReorderLevel,");
                    sb.AppendLine("Discontinued = @Discontinued");
                    sb.AppendLine("WHERE ProductID = @id");
                    using (SqlCommand cmd = new SqlCommand(sb.ToString(), conn))
                    {
                        cmd.Parameters.AddWithValue("@ProductName", pro.ProductName);
                        cmd.Parameters.AddWithValue("@SupplierID", pro.SupplierID);
                        cmd.Parameters.AddWithValue("@CategoryID", pro.CategoryID);
                        cmd.Parameters.AddWithValue("@UnitPrice", pro.UnitPrice);
                        cmd.Parameters.AddWithValue("@QuantityPerUnit", pro.QuantityPerUnit);
                        cmd.Parameters.AddWithValue("@UnitsOnOrder", pro.UnitsOnOrder);
                        cmd.Parameters.AddWithValue("@UnitsInStock", pro.UnitsInStock);
                        cmd.Parameters.AddWithValue("@ReorderLevel", pro.ReorderLevel);
                        cmd.Parameters.AddWithValue("@Discontinued", pro.Discontinued);
                        cmd.Parameters.AddWithValue("@id", pro.ProductID);

                        cmd.ExecuteNonQuery();
                    }
                }
                return true;
            }
            return false;

        }
        public bool Delete(int id)
        {
            return true;

        }
        public Product GetById(int id)
        {
            using (conn = new SqlConnection(Conn_String))
            {
                conn.Open();
                string query = "SELECT * FROM dbo.Products Where ProductID = @id";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);

                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            pro.ProductID = Convert.ToInt32(dr["ProductID"]);
                            pro.ProductName = dr["ProductName"].ToString() ?? "";
                            pro.SupplierID = Convert.ToInt32(dr["SupplierID"]);
                            pro.CategoryID = Convert.ToInt32(dr["CategoryID"]);
                            pro.UnitPrice = Convert.ToDecimal(dr["UnitPrice"]);
                            pro.QuantityPerUnit = dr["QuantityPerUnit"].ToString() ?? "";
                            pro.UnitsOnOrder = Convert.ToInt16(dr["UnitsOnOrder"]);
                            pro.UnitsInStock = Convert.ToInt16(dr["UnitsInStock"]);
                            pro.ReorderLevel = Convert.ToInt16(dr["ReorderLevel"]);
                            pro.Discontinued = Convert.ToBoolean(dr["Discontinued"]);

                        }
                    }
                }
            }

            return pro;
        }
        public DataSet GetAll(int CateId)
        {
            DataSet ds = new DataSet();
            using (conn = new SqlConnection(Conn_String))
            {
                conn.Open();
                string query = $"SELECT * from dbo.Products where CategoryID = {CateId}";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(ds);
                    return ds;
                }

            }
        }

        public DataTable LoadComboSupplier()
        {
            using (conn = new SqlConnection(Conn_String))
            {
                conn.Open();
                string query = "select  SupplierID,ContactName AS [SupplierName] from dbo.Suppliers";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    return dt;
                }
            }
        }

        
    }
}
