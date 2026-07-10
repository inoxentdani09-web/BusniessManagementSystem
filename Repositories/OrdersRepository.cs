using BusniessManagementSystem.Models;
using Microsoft.Data.SqlClient;
using System.Data;

namespace BusniessManagementSystem.Repositories
{
    public  class OrdersRepository
    {
        string Connecting_String = "Server=(localdb)\\MSSQLLocalDB;Database=Northwind;Trusted_Connection=True;";
        SqlConnection conn = null!;

        public int InsertOrder(Order order)
        {
            using(conn = new SqlConnection(Connecting_String))
            {
                conn.Open();
                using(SqlCommand cmd = new SqlCommand("sp_Insert_Orders", conn))
                {

                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@CustomerID", order.CustomerID);
                    cmd.Parameters.AddWithValue("@EmployeeID", order.EmployeeID);
                    cmd.Parameters.AddWithValue("@OrderDate", order.OrderDate);

                    int orderId = Convert.ToInt32(cmd.ExecuteScalar());
                    return orderId;
                }
            }
        }
        public int InsertOrderDetails(OrderDetails Details)
        {
            using (conn = new SqlConnection(Connecting_String))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("sp_Insert_OrderDetails", conn))
                {

                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ProductID", Details.ProductID);
                    cmd.Parameters.AddWithValue("@UnitPrice", Details.UnitPrice);
                    cmd.Parameters.AddWithValue("@Qty", Details.Qty);
                    cmd.Parameters.AddWithValue("@Discount", Details.Discount);

                    int orderId = cmd.ExecuteNonQuery();
                    return orderId;
                }
            }
        }
    }
}
