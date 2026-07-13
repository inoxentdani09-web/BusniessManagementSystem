using BusniessManagementSystem.Models;
using BusniessManagementSystem.Modules;
using Microsoft.Data.SqlClient;
using System.Data;

namespace BusniessManagementSystem.Repositories
{
    public class OrdersRepository
    {
        string Connecting_String = "Server=(localdb)\\MSSQLLocalDB;Database=Northwind;Trusted_Connection=True;";
        SqlConnection conn = null!;

        public int InsertOrder(Order order)
        {
            using (conn = new SqlConnection(Connecting_String))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("sp_Insert_Orders", conn))
                {

                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@CustomerId", order.CustomerId);
                    cmd.Parameters.AddWithValue("@EmployeeId", order.EmployeeId);
                    cmd.Parameters.AddWithValue("@OrderDate", order.OrderDate);
                    cmd.Parameters.Add("@OrderId", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.ExecuteNonQuery();
                    int orderId = Convert.ToInt32(cmd.Parameters["@OrderId"].Value);
                    return orderId;
                }
            }
        }
        public bool InsertOrderDetails(OrderDetails Details)
        {
            using (conn = new SqlConnection(Connecting_String))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("sp_Insert_OrderDetails", conn))
                {

                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@OrderId", Details.OrderId);
                    cmd.Parameters.AddWithValue("@ProductId", Details.ProductId);
                    cmd.Parameters.AddWithValue("@UnitPrice", Details.UnitPrice);
                    cmd.Parameters.AddWithValue("@Qty", Details.Qty);
                    cmd.Parameters.AddWithValue("@Discount", Details.Discount);

                    cmd.ExecuteNonQuery();
                    return true;
                }
            }
        }
    }
}
