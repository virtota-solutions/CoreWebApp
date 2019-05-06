using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MySql.Data.MySqlClient;


namespace PCVMurcorWebApp.Models
{
    public class UserDataContext : IDisposable
    {
        public MySqlConnection Connection;

        public string ConnectionString { get; set; }

        public UserDataContext(string connectionString)
        {
            Connection = new MySqlConnection(connectionString);
        }

        private MySqlConnection GetConnection()
        {
      
            return new MySqlConnection(ConnectionString);
        }

        public void Dispose()
        {
            Connection.Close();
        }


    }
}
