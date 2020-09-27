using System;
using System.Threading.Tasks;
using backend.Database;
using Dapper;
using Microsoft.Data.Sqlite;

namespace backend.ProductMaster
{
    public class ProductRepository : IProductRepository
    {
        private readonly DatabaseConfig databaseConfig;

        public ProductRepository(DatabaseConfig databaseConfig)
        {
            this.databaseConfig = databaseConfig;
        }

        public async Task Create(Product product)
        {
            using var connection = new SqliteConnection($"Data Source={databaseConfig.Name}");

            await connection.ExecuteAsync("INSERT INTO Product (Name, Description) VALUES (@Name, @Description);", product);
        }
    }
}
