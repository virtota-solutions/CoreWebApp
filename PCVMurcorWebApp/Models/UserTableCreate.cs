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
                ParameterName = "@firstname",
                DbType = DbType.String,
                Value = FirstName,
            });
            cmd.Parameters.Add(new MySqlParameter
            {
                ParameterName = "@lastname",
                DbType = DbType.String,
                Value = LastName,
            });
            cmd.Parameters.Add(new MySqlParameter
            {
                ParameterName = "@department",
                DbType = DbType.String,
                Value = Department,
            });
            cmd.Parameters.Add(new MySqlParameter
            {
                ParameterName = "@managerName",
                DbType = DbType.String,
                Value = ManagerName,
            });
            cmd.Parameters.Add(new MySqlParameter
            {
                ParameterName = "@isManager",
                DbType = DbType.Boolean,
                Value = IsManager,
            });
            cmd.Parameters.Add(new MySqlParameter
            {
                ParameterName = "@dateStart",
                DbType = DbType.DateTime,
                Value = DateStart,
            });
            cmd.Parameters.Add(new MySqlParameter
            {
                ParameterName = "@dateEnd",
                DbType = DbType.DateTime,
                Value = DateEnd,
            });
        }
    }
}
