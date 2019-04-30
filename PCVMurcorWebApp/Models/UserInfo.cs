using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PCVMurcorWebApp.Models
{
    public class UserInfo
    {

        public long Id { get; set; }

        private string _key;

        public string Key
        {
            get
            {
                if (_key == null)
                {
                    //_key = Regex.Replace(RequestBy.ToLower(), "[^a-z0-9]", "-");
                }
                return _key;
            }
            set { _key = value; }
        }

        public DateTime TodayDate { get; set; }
        [Required]
        [DataType(DataType.Text)]
        public string RequestType { get; set; }
        [Required]
        [DataType(DataType.Text)]
        public string RequestBy { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime StartDate { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime EndDate { get; set; }
    }
}
