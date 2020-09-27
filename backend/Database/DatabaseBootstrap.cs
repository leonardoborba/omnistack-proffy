using Dapper;
using Microsoft.Data.Sqlite;
using System.Linq;

namespace backend.Database
{
    public class DatabaseBootstrap : IDatabaseBootstrap
    {
        private readonly DatabaseConfig databaseConfig;

        public DatabaseBootstrap(DatabaseConfig databaseConfig)
        {
            this.databaseConfig = databaseConfig;
        }

        public void Setup()
        {
            using var connection = new SqliteConnection($"Data Source={databaseConfig.Name}");

            connection.Execute("Create Table IF NOT EXISTS users (" +
                "id INTEGER PRIMARY KEY AUTOINCREMENT," +
                "name VARCHAR(250) NOT NULL," +
                "avatar VARCHAR(250) NOT NULL," +
                "whatsapp VARCHAR(100) NOT NULL," +
                "bio VARCHAR(100) NOT NULL" +
                ");");

            connection.Execute("Create Table IF NOT EXISTS classes (" +
                "id INTEGER PRIMARY KEY AUTOINCREMENT," +
                "subject VARCHAR(250) NOT NULL," +
                "cost DECIMAL NOT NULL," +
                "user_id int NOT NULL," +
                "FOREIGN KEY (user_id) REFERENCES users(id)" +
                ");");

            connection.Execute("Create Table IF NOT EXISTS classe_schedule (" +
                "id INTEGER PRIMARY KEY AUTOINCREMENT," +
                "week_day INT NOT NULL," +
                "'from' INT NOT NULL," +
                "'to' INT NOT NULL," +
                "class_id INT NOT NULL," +
                "FOREIGN KEY (class_id) REFERENCES classes(id)" +
                ");");

            connection.Execute("Create Table IF NOT EXISTS connections (" +
                "id INTEGER PRIMARY KEY AUTOINCREMENT," +
                "user_id int NOT NULL," +
                "created_at TIMESTAMP DEFAULT CURRENT_TIMESTAMP," +
                "FOREIGN KEY (user_id) REFERENCES users(id)" +
                ");");
        }
    }
}