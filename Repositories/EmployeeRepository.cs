using BusniessManagementSystem.Modules;
using Microsoft.Data.SqlClient;
using System.Data;
using System.Text;

namespace BusniessManagementSystem.EmployeeRepositories
{
    public class EmployeeRepository
    {
        string Conn_String = "Server=(localdb)\\MSSQLLocalDB;Database=Northwind;Trusted_Connection=True;";
        SqlConnection conn = null!;
        Employee emp = new Employee();
        public bool Insert(Employee emp)
        {
            DialogResult result = MessageBox.Show("Save Successfullly", "Save Employee", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (result == DialogResult.Cancel)
            {
                return true;
            }
            using (conn = new SqlConnection(Conn_String))
            {
                conn.Open();

                string query = "INSERT INTO dbo.Employees ( LastName,FirstName,Title,TitleOfCourtesy,BirthDate,HireDate,Address,City,Region,PostalCode,Country,HomePhone,Extension,Photo,Notes,ReportsTo,PhotoPath)" +
                "Values(@LastName,@FirstName,@Title,@TitleOfCourtesy,@BirthDate,@HireDate,@Address,@City,@Region,@PostalCode,@Country,@HomePhone,@Extension,@Photo,@Notes,@ReportsTo,@PhotoPath)";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@LastName", emp.LastName);
                    cmd.Parameters.AddWithValue("@FirstName", emp.FirstName);
                    cmd.Parameters.AddWithValue("@Title", emp.Title);
                    cmd.Parameters.AddWithValue("@TitleOfCourtesy", emp.TitleOfCourtesy);
                    cmd.Parameters.AddWithValue("@BirthDate", SqlDbType.DateTime2).Value = emp.BirthDate;
                    cmd.Parameters.AddWithValue("@HireDate", SqlDbType.DateTime2).Value = emp.HireDate;
                    cmd.Parameters.AddWithValue("@Address", emp.Address);
                    cmd.Parameters.AddWithValue("@City", emp.City);
                    cmd.Parameters.AddWithValue("@Region", emp.Region);
                    cmd.Parameters.AddWithValue("@PostalCode", emp.PostCode);
                    cmd.Parameters.AddWithValue("@Country", emp.Country);
                    cmd.Parameters.AddWithValue("@HomePhone", emp.HomePhone);
                    cmd.Parameters.AddWithValue("@Extension", emp.Extension);
                    cmd.Parameters.Add("@Photo", SqlDbType.VarBinary, -1).Value = emp.Photo ?? (Object)DBNull.Value;
                    cmd.Parameters.AddWithValue("@Notes", emp.Notes);
                    cmd.Parameters.Add("@ReportsTo", SqlDbType.Int).Value = emp.ReportsTo == 0 ? DBNull.Value : emp.ReportsTo;
                    cmd.Parameters.AddWithValue("@PhotoPath", string.IsNullOrEmpty(emp.PhotoPath) ? DBNull.Value : emp.PhotoPath);

                    cmd.ExecuteNonQuery();
                    conn.Close();

                }
            }
            return true;
        }

        public bool Update(Employee emp)
        {
            DialogResult result = MessageBox.Show("Are you sure Employee edit", "Edit Employee", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (result == DialogResult.OK)
            {
                using (conn = new SqlConnection(Conn_String))
                {
                    conn.Open();
                    StringBuilder sb = new StringBuilder();
                    sb.AppendLine("UPDATE dbo.Employees set");
                    sb.AppendLine("FirstName = @FirstName,");
                    sb.AppendLine("LastName = @LastName,");
                    sb.AppendLine("City = @City,");
                    sb.AppendLine("HomePhone = @HomePhone,");
                    sb.AppendLine("Region = @Region,");
                    sb.AppendLine("PostalCode = @PostalCode,");
                    sb.AppendLine("Country = @Country,");
                    sb.AppendLine("Extension = @Extension,");
                    sb.AppendLine("Notes = @Notes,");
                    sb.AppendLine("ReportsTo = @ReportsTo,");
                    sb.AppendLine("TitleOfCourtesy = @TitleOfCourtesy,");
                    sb.AppendLine("Title = @Title,");
                    sb.AppendLine("BirthDate = @BirthDate,");
                    sb.AppendLine("HireDate = @HireDate,");
                    sb.AppendLine("Address = @Address,");
                    sb.AppendLine("Photo = @Photo");
                    sb.AppendLine("Where EmployeeID = @Id");

                    using (SqlCommand cmd = new SqlCommand(sb.ToString(), conn))
                    {
                        cmd.Parameters.AddWithValue("@FirstName", emp.FirstName);
                        cmd.Parameters.AddWithValue("@LastName", emp.LastName);
                        cmd.Parameters.AddWithValue("@City", emp.City);
                        cmd.Parameters.AddWithValue("@HomePhone", emp.HomePhone);
                        cmd.Parameters.AddWithValue("@Region", emp.Region);
                        cmd.Parameters.AddWithValue("@PostalCode", emp.PostCode);
                        cmd.Parameters.AddWithValue("@Country", emp.Country);
                        cmd.Parameters.AddWithValue("@Extension", emp.Extension);
                        cmd.Parameters.AddWithValue("@Notes", emp.Notes);
                        cmd.Parameters.Add("@ReportsTo", SqlDbType.Int).Value = emp.ReportsTo ?? (object)DBNull.Value;
                        cmd.Parameters.AddWithValue("@TitleOfCourtesy", emp.TitleOfCourtesy);
                        cmd.Parameters.AddWithValue("@Title", emp.Title);
                        cmd.Parameters.AddWithValue("@BirthDate", emp.BirthDate);
                        cmd.Parameters.AddWithValue("@HireDate", emp.HireDate);
                        cmd.Parameters.AddWithValue("@Address", emp.Address);
                        cmd.Parameters.Add("@Photo", SqlDbType.VarBinary, -1).Value = (object)emp.Photo ?? DBNull.Value;
                        cmd.Parameters.AddWithValue("@Id", emp.Id);

                        cmd.ExecuteNonQuery();
                    }
                }
                return true;
            }
            return false;
        }

        public bool Delete(int id)
        {
            using (SqlConnection conn = new SqlConnection(Conn_String))
            {
                conn.Open();

                string q1 = "DELETE FROM [Order Details] WHERE OrderID IN (Select OrderID from Orders WHERE EmployeeID = @id)";

                using (SqlCommand cmd1 = new SqlCommand(q1, conn))
                {
                    cmd1.Parameters.AddWithValue("@id", id);
                    cmd1.ExecuteNonQuery();
                }


                string q2 = "DELETE FROM Orders WHERE EmployeeID = @id";

                using (SqlCommand cmd2 = new SqlCommand(q2, conn))
                {
                    cmd2.Parameters.AddWithValue("@id", id);
                    cmd2.ExecuteNonQuery();
                }
                string q3 = "DELETE FROM EmployeeTerritories WHERE EmployeeID = @id";
                using (SqlCommand cmd3 = new SqlCommand(q3, conn))
                {
                    cmd3.Parameters.AddWithValue("@id", id);
                    cmd3.ExecuteNonQuery();

                }
                string q0 = "UPDATE Employees SET ReportsTo = Null WHERE ReportsTo = @id";
                using (SqlCommand cmd0 = new SqlCommand(q0, conn))
                {
                    cmd0.Parameters.AddWithValue("@id", id);
                    cmd0.ExecuteNonQuery();
                }
                string q4 = "DELETE FROM Employees WHERE EmployeeID = @id";
                using (SqlCommand cmd4 = new SqlCommand(q4, conn))
                {
                    cmd4.Parameters.AddWithValue("@id", id);
                    int row = cmd4.ExecuteNonQuery();
                    if (row > 0)
                    {
                        MessageBox.Show("Delete successfull");
                        return true;
                    }

                }
            }

            return false;
        }

        public Employee GetById(int id)
        {
            using (conn = new SqlConnection(Conn_String))
            {
                conn.Open();
                string query = "Select e.*," +
                    "r.FirstName + ' ' + r.LastName AS [ReportsToName]" +
                    " from Employees e " +
                    "Left Join Employees r " +
                    "ON e.ReportsTo = r.EmployeeID" +
                    " Where e.EmployeeID = @id ";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.HasRows)
                        {
                            while (dr.Read())
                            {
                                emp.Id = Convert.ToInt32(dr["EmployeeID"]);
                                emp.FirstName = dr["FirstName"].ToString() ?? "";
                                emp.LastName = dr["LastName"].ToString() ?? "";
                                emp.City = dr["City"].ToString() ?? "";
                                emp.HomePhone = dr["HomePhone"].ToString() ?? "";
                                emp.Region = dr["Region"].ToString() ?? "";
                                emp.PostCode = dr["PostalCode"].ToString() ?? "";
                                emp.Country = dr["Country"].ToString() ?? "";
                                emp.Extension = dr["Extension"].ToString() ?? "";
                                emp.Notes = dr["Notes"].ToString() ?? "";
                                emp.ReportsTo = dr["ReportsTo"] == DBNull.Value ? 0 : Convert.ToInt32(dr["ReportsTo"]);
                                emp.TitleOfCourtesy = dr["TitleOfCourtesy"].ToString() ?? "";
                                emp.Title = dr["Title"].ToString() ?? "";
                                emp.BirthDate = Convert.ToDateTime(dr["BirthDate"]);
                                emp.HireDate = Convert.ToDateTime(dr["HireDate"]);
                                emp.Address = dr["Address"].ToString() ?? "";
                                emp.ReportsToName = dr["ReportsToName"].ToString() ?? "";
                                emp.Photo = dr["Photo"] == DBNull.Value ? null : (byte[])dr["Photo"];

                            }
                        }
                    }

                }

            }
            return emp;

        }

        public DataSet GetAll()
        {
            DataSet ds = new DataSet();
            using (conn = new SqlConnection(Conn_String))
            {
                conn.Open();
                string query = "select EmployeeID, TitleOfCourtesy, FirstName, LastName, Address  FROM dbo.Employees";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    SqlDataAdapter da = new SqlDataAdapter(cmd);

                    da.Fill(ds);
                    return ds;
                }
            }
        }

        public DataTable SearchEmployee(Employee emp)
        {
            using (conn = new SqlConnection(Conn_String))
            {
                conn.Open();
                StringBuilder sb = new StringBuilder();
                sb.AppendLine("select * from  dbo.Employees Where 1 = 1");
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                if (!string.IsNullOrEmpty(emp.FirstName))
                {
                    sb.AppendFormat(" and FirstName Like @FirstName");
                    cmd.Parameters.AddWithValue("@FirstName", "%" + emp.FirstName + "%");
                }
                if (!string.IsNullOrEmpty(emp.LastName))
                {
                    sb.AppendFormat(" and LastName Like @LastName");
                    cmd.Parameters.AddWithValue("@LastName", "%" + emp.LastName + "%");

                }
                if (!string.IsNullOrEmpty(emp.Address))
                {
                    sb.AppendFormat(" and Address like @Address");
                    cmd.Parameters.AddWithValue("@Address", "%" + emp.Address + "%");

                }
                if (!string.IsNullOrEmpty(emp.PostCode))
                {
                    sb.AppendFormat(" and PostalCode like @PostCode");
                    cmd.Parameters.AddWithValue("@PostCode", "%" + emp.PostCode + "%");

                }
                if (emp.ReportsTo > 0)
                {
                    sb.AppendFormat(" and ReportsTo like @ReportsTo", emp.ReportsTo);
                    cmd.Parameters.AddWithValue("@ReportsTo",emp.ReportsTo);

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
