using MySql.Data.MySqlClient;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace PCVMurcorWebApp.Models
{
    public class UserRequirements
    {
        public int UserId { get; set; }
        public int FloorNum { get; set; }
        public int CubeNum { get; set; }
        public int NewFloorNum { get; set; }
        public int NewCubeNum { get; set; }
        public Boolean DidNum { get; set; }
        public Boolean DualMon { get; set; }
        public Boolean RemoAcc { get; set; }
        public Boolean RemoLap { get; set; }
        public Boolean Mobile { get; set; }
        public string CopyProfile { get; set; }
        public string UserStatusChange { get; set; }
        public string UserNameChange { get; set; }
        public string LOA { get; set; }
        [JsonIgnore]
        public UserDataContext Db { get; set; }

        public UserRequirements(UserDataContext db = null)
        {
            Db = db;
        }
        public async Task InsertAsync()
        {
            var cmd = Db.Connection.CreateCommand() as MySqlCommand;
            cmd.CommandText = @"INSERT INTO `user_requirements` (`floorNum`, `cubeNum`, `didNum`, `dualMon`, `remoAcc`, `remoLap`, `mobile`, `userStatus`, `userName`) VALUES (@floornum, @cubenum, @didnum, @dualmon, @remoacc, @remolap, @mobile, @userstatus, @username);";
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
                ParameterName = "@floornum",
                DbType = DbType.Int32,
                Value = FloorNum,
            });
            cmd.Parameters.Add(new MySqlParameter
            {
                ParameterName = "@cubenum",
                DbType = DbType.Int32,
                Value = CubeNum,
            });
            cmd.Parameters.Add(new MySqlParameter
            {
                ParameterName = "@didnum",
                DbType = DbType.Boolean,
                Value = DidNum,
            });
            cmd.Parameters.Add(new MySqlParameter
            {
                ParameterName = "@dualmon",
                DbType = DbType.Boolean,
                Value = DualMon,
            });
            cmd.Parameters.Add(new MySqlParameter
            {
                ParameterName = "@remoacc",
                DbType = DbType.Boolean,
                Value = RemoAcc,
            });
            cmd.Parameters.Add(new MySqlParameter
            {
                ParameterName = "@remolap",
                DbType = DbType.Boolean,
                Value = RemoLap,
            });
            cmd.Parameters.Add(new MySqlParameter
            {
                ParameterName = "@mobile",
                DbType = DbType.Boolean,
                Value = Mobile,
            });
            cmd.Parameters.Add(new MySqlParameter
            {
                ParameterName = "@userstatus",
                DbType = DbType.String,
                Value = UserStatusChange,
            });
            cmd.Parameters.Add(new MySqlParameter
            {
                ParameterName = "@username",
                DbType = DbType.String,
                Value = UserNameChange,
            });
        }
    }
}


