using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using backend.Database;
using Dapper;
using backend.Models;
using Microsoft.Data.Sqlite;

namespace backend.Services
{
    public class UserService : IUserService
    {
        private readonly DatabaseConfig databaseConfig;
        private SqliteConnection connection;

        public UserService(DatabaseConfig databaseConfig)
        {
            this.databaseConfig = databaseConfig;
            this.connection = new SqliteConnection($"Data Source={databaseConfig.Name}");
        }

        public async Task<IEnumerable<User>> Get()
        {
            return await this.connection.QueryAsync<User>("SELECT id, name, avatar, whatsapp, bio FROM users");
        }

        public async Task Create(User user)
        {
            await this.connection.ExecuteAsync("INSERT INTO Users (name, avatar, whatsapp, bio) VALUES (@name, @avatar, @whatsapp, @bio);", user);
        }
    }

}
