using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Engine.ViewModels
{
    public class DatabaseConnection
    {
        public MySqlConnection cnn;

        public DatabaseConnection()
        {
            cnn = new MySqlConnection();

            var builder = new MySqlConnectionStringBuilder
            {
                Server = "web0078.zxcs.nl",
                Port = 3306,
                UserID = "errowdesign_popcornplaza",
                Password = "Welkom123",
            };

            cnn = new MySqlConnection(builder.ConnectionString);
        }

    }
}
