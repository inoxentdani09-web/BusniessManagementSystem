using BusniessManagementSystem.Modules;
using Microsoft.Data.SqlClient;
using System.Data;
using System.Text;


namespace BusniessManagementSystem.Repositories
{
    public class CustomerRepository
    {
        string Connecting_String = "Server=(localdb)\\MSSQLLocalDB;Database=Northwind;Trusted_Connection=True;";
        SqlConnection conn = null!;
        Customer cus = new Customer();
        public bool Insert(Customer cus)
        {

            using (conn = new SqlConnection(Connecting_String))
            {
                conn.Open();
                StringBuilder sb = new StringBuilder();
                sb.AppendLine("INSERT INTO dbo.Customers(");
                sb.AppendLine("CustomerID,CompanyName,ContactName,ContactTitle,Address,City,Region,PostalCode,Country,Phone,Fax)");
                sb.AppendLine("VALUES(");
                sb.AppendFormat("'{0}',", cus.CustomerID);
                sb.AppendFormat("'{0}',", cus.CompanyName);
                sb.AppendFormat("'{0}',", cus.ContactName);
                sb.AppendFormat("'{0}',", cus.ContactTitle);
                sb.AppendFormat("'{0}',", cus.Address);
                sb.AppendFormat("'{0}',", cus.City);
                sb.AppendFormat("'{0}',", cus.Region);
                sb.AppendFormat("'{0}',", cus.PostalCode);
                sb.AppendFormat("'{0}',", cus.Country);
                sb.AppendFormat("'{0}',", cus.Phone);
                sb.AppendFormat("'{0}')", cus.Fax);

                using (SqlCommand cmd = new SqlCommand(sb.ToString(), conn))
                {
                    int row = cmd.ExecuteNonQuery();
                    if (row > 0)
                    {
                        MessageBox.Show("Customer Save Successfully.", "Save",
                                  MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return true;
                    }
                }

            }
            return false;
        }
        public bool Update(Customer cus)
        {
            DialogResult result = MessageBox.Show("Are you sure Employee edit", "Edit Employee", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (result == DialogResult.OK)
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendLine("UPDATE Customers Set");
                sb.AppendLine($"CustomerID = '{cus.CustomerID}',");
                sb.AppendLine($"CompanyName = '{cus.CompanyName}',");
                sb.AppendLine($"ContactName = '{cus.ContactName}',");
                sb.AppendLine($"ContactTitle = '{cus.ContactTitle}',");
                sb.AppendLine($"Address = '{cus.Address}',");
                sb.AppendLine($"City = '{cus.City}',");
                sb.AppendLine($"Region = '{cus.Region}',");
                sb.AppendLine($"PostalCode = '{cus.PostalCode}',");
                sb.AppendLine($"Country = '{cus.Country}',");
                sb.AppendLine($"Phone = '{cus.Phone}',");
                sb.AppendLine($"Fax = '{cus.Fax}'");
                sb.AppendLine($"WHERE CustomerID = '{cus.CustomerID}'");

                using (conn = new SqlConnection(Connecting_String))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(sb.ToString(), conn))
                    {
                        cmd.ExecuteNonQuery();
                    }
                }
                return true;

            }
            return false;
        }
        public bool Delete(string id)
        {
            DialogResult result = MessageBox.Show("Are you sure Employee edit", "Edit Employee", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (result == DialogResult.OK)
            {
                using (conn = new SqlConnection(Connecting_String))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand())
                    {
                        cmd.CommandType = CommandType.Text;
                        cmd.Connection = conn;
                        cmd.CommandText = "Delete from dbo.Customers Where CustomerID = @id";
                        cmd.Parameters.AddWithValue("@id", id);

                        int row = cmd.ExecuteNonQuery();
                        if (row > 0)
                        {
                            MessageBox.Show("Delete successfully", "Delete", MessageBoxButtons.OK);
                            return true;
                        }
                    }
                }
            }
            return false;
        }
        public Customer GetById(string id)
        {
            using (conn = new SqlConnection(Connecting_String))
            {
                conn.Open();
                string query = "SELECT * FROM Customers where CustomerId = @id";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.HasRows)
                        {
                            while (dr.Read())
                            {
                                cus.CustomerID = dr["CustomerID"].ToString() ?? "";
                                cus.CompanyName = dr["CompanyName"].ToString() ?? "";
                                cus.ContactName = dr["ContactName"].ToString() ?? "";
                                cus.ContactTitle = dr["ContactTitle"].ToString() ?? "";
                                cus.City = dr["City"].ToString() ?? "";
                                cus.Country = dr["Country"].ToString() ?? "";
                                cus.Region = dr["Region"].ToString() ?? "";
                                cus.Address = dr["Address"].ToString() ?? "";
                                cus.Fax = dr["ContactName"].ToString() ?? "";
                                cus.Phone = dr["Phone"].ToString() ?? "";
                                cus.PostalCode = dr["PostalCode"].ToString() ?? "";
                            }
                        }
                    }
                }
            }
            return cus;
        }
        public DataSet GetAll()
        {
            DataSet ds = new DataSet();
            using (conn = new SqlConnection(Connecting_String))
            {
                conn.Open();
                string query = "select '' AS CustomerID,'Select Customer' AS CustomerName Union All Select CustomerID,ContactName from dbo.Customers";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    SqlDataAdapter da = new SqlDataAdapter(cmd);

                    da.Fill(ds);
                    return ds;
                }
            }
        }
        public DataTable SearchCustomer(Customer cus)
        {
            using (conn = new SqlConnection(Connecting_String))
            {
                conn.Open();
                StringBuilder sb = new StringBuilder();
                sb.AppendLine("select * from Customers Where 1 = 1");

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;

                if (!string.IsNullOrEmpty(cus.CustomerID))
                {
                    sb.AppendFormat(" and CustomerID Like @CustomerID");
                    cmd.Parameters.AddWithValue("@CustomerID", "%" + cus.CustomerID + "%");
                }
                if (!string.IsNullOrEmpty(cus.CompanyName))
                {
                    sb.AppendFormat(" and CompanyName Like @CompanyName");
                    cmd.Parameters.AddWithValue("@CompanyName", "%" + cus.CompanyName + "%");
                }
                if (!string.IsNullOrEmpty(cus.ContactName))
                {
                    sb.AppendFormat(" and ContactName Like @ContactName");
                    cmd.Parameters.AddWithValue("@ContactName", "%" + cus.ContactName + "%");
                }
                if (!string.IsNullOrEmpty(cus.City))
                {
                    sb.AppendFormat(" and City Like @City");
                    cmd.Parameters.AddWithValue("@City", "%" + cus.City + "%");
                }
                if (!string.IsNullOrEmpty(cus.PostalCode))
                {
                    sb.AppendFormat(" and PostalCode Like @PostalCode");
                    cmd.Parameters.AddWithValue("@PostalCode", "%" + cus.PostalCode + "%");
                }
                cmd.CommandText = sb.ToString();
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                DataTable dt = new DataTable();
                da.Fill(dt);        
                return dt;
            }
        }

    }
}
