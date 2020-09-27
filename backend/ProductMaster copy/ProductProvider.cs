using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using backend.Database;
using Dapper;
using Microsoft.Data.Sqlite;

namespace backend.ProductMaster
{
    public class ProductProvider : IProductProvider
    {
        private readonly DatabaseConfig databaseConfig;

        public ProductProvider(DatabaseConfig databaseConfig)
        {
            this.databaseConfig = databaseConfig;
        }

        public async Task<IEnumerable<Product>> Get()
        {
            using var connection = new SqliteConnection($"Data Source={databaseConfig.Name}");

            return await connection.QueryAsync<Product>("SELECT rowid as Id, Name, Description FROM Product");
        }
    }

}
