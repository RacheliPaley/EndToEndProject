using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.DTO_s
{
    public class UserDTO
    {
        public int Id { get; set; }
        public string Fname { get; set; }

        public string Lname { get; set; }

        public DateTime DateOfBirdth { get; set; }
        public string Tz { get; set; }
        public string Min { get; set; }
        public string Hmo { get; set; }
    }
}
