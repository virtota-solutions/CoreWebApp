using MySql.Data.MySqlClient;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace PCVMurcorWebApp.Models
{
    public class UserTableCreate
    {
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Department { get; set; }
        public string Office { get; set; }
        public string ManagerName { get; set; }
        public bool IsManager { get; set; }
        public DateTime DateStart { get; set; }
        public DateTime DateEnd { get; set; }

        [JsonIgnore]
        public UserDataContext Db { get; set; }

        public UserTableCreate(UserDataContext db = null)
        {
            Db = db;
        }

        public async Task InsertAsync()
        {
            var cmd = Db.Connection.CreateCommand() as MySqlCommand;
            cmd.CommandText = @"INSERT INTO `user_table` (`FirstName`, `LastName`, `department`, `office`, `managerName`, `isManager`, `dateStart`, `dateEnd`) VALUES (@firstname, @lastname, @department, @office, @managerName, @isManager, @dateStart, @dateEnd);";
            BindParams(cmd);
            await cmd.ExecuteNonQueryAsync();
            UserId = (int)cmd.LastInsertedId;
        }

        public async Task UpdateAsync()
        {
            var cmd = Db.Connection.CreateCommand() as MySqlCommand;
            cmd.CommandText = @"UPDATE `BlogPost` SET `Title` = @title, `Content` = @content WHERE `Id` = @id;";
            BindParams(cmd);
            BindId(cmd);
            await cmd.ExecuteNonQueryAsync();
        }

        public async Task DeleteAsync()
        {
            var cmd = Db.Connection.CreateCommand() as MySqlCommand;
            cmd.CommandText = @"DELETE FROM `BlogPost` WHERE `Id` = @id;";
            BindId(cmd);
            await cmd.ExecuteNonQueryAsync();
        }

        private void BindId(MySqlCommand cmd)
        {
            cmd.Parameters.Add(new MySqlParameter
            {
                ParameterName = "@id",
                DbType = DbType.Int32,
                Value = UserId,
            });
        }

        private void BindParams(MySqlCommand cmd)
        {
            cmd.Parameters.Add(new MySqlParameter
            {
                ParameterName = "@title",
                DbType = DbType.String,
                Value = Title,
            });
            cmd.Parameters.Add(new MySqlParameter
            {
                ParameterName = "@content",
                DbType = DbType.String,
                Value = Content,
            });
        }
    }
}
