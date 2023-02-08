using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.DTO_s
{
    public class ChildDTO
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int ChildTz { get; set; }
        public DateTime Date { get; set; }
       
        public int PareentId { get; set; }
        //public UserDTO Parent { get; set; }
    }
}
