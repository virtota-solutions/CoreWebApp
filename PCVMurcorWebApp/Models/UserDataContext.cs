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

        public List<UserTableCreate> GetUserTable()
        {
            List<UserTableCreate> list = new List<UserTableCreate>();

            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("select * from user_table where id < 10", conn);

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new UserTableCreate()
                        {


                            UserId = Convert.ToInt32(reader["UserId"]),
                            FirstName = reader["FirstName"].ToString(),
                            Department = reader["Department"].ToString(),
                            Office = reader["Office"].ToString(),
                            ManagerName = reader["ManagerName"].ToString(),
                            IsManager = Convert.ToBoolean(reader["IsManager"]),
                            DateStart = Convert.ToDateTime(reader["DateStart"]),
                            DateEnd = Convert.ToDateTime(reader["DateEnd"])
                        });
                    }
                }
            }
            return list;
        }


    }
}
