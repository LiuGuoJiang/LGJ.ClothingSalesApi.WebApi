using LGJ.ClothingSale.DataAccess.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LGJ.Data.DapperExtensions;

namespace LGJ.ClothingSale.DataAccess.Repositories.Orders
{
    public class ClothingOrderRepository:AbstractRepository<dynamic>
    {
        private readonly string _connection;
        private readonly string _clothingOrderTableName = "ClothingOrders";
        public ClothingOrderRepository()
        {
            ConnectionString = "Server=localhost;port=3306; Database=CaiLinPersonalWebDb;User=root;Password=root;SslMode = none;";
            SlaveConnectionString =
                "Server=localhost;port=3306; Database=CaiLinPersonalWebDb;User=root;Password=root;SslMode = none;";
        }
        public async Task<List<ClothingOrder>> GetAllClothingOrdersAsync()
        {
            var result =await GetListAsync<ClothingOrder>(new { });
            return result?.ToList();
        }

        public async Task<ClothingOrder> GetClothingOrderByIdAsync(int id)
        {
            var result = Get<ClothingOrder>(id);
            return result;
        }
        public async Task<bool> DeleteClothingOrderByIdAsync(int id)
        {
            int changeCount = 0;
            changeCount =await DeleteAsync<ClothingOrder>(id);

            return changeCount > 0;
        }

        //public async Task<bool> AddClothingOrder(ClothingOrder orderInfo)
        //{
        //    long changeCount = 0;
        //    using (var conn = new MySqlConnection(_connection))
        //    {
        //        changeCount = await conn.InsertAsync(orderInfo, _clothingOrderTableName);
        //    }

        //    return changeCount > 0;
        //}
    }
}
