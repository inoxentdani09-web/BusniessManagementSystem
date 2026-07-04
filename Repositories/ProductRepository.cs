using BusniessManagementSystem.Models;
using System.Data;

namespace BusniessManagementSystem.Repositories
{
    public class ProductRepository
    {
        public bool Insert(Product pro)
        {
            return true;
        }
        public bool Update(Product pro)
        {
            return true;

        }
        public bool Delete(int id)
        {
            return true;

        }
        public Product GetById(int id)
        {
            Product pro = new Product();
            return pro;
        }
        public DataSet GetAllId(int id)
        {
            DataSet ds = new DataSet();
            return ds;
        }
    }
}
