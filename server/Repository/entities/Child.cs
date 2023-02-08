using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.entities
{
    public class Child
    {
        [Key]
        public int Id { get; set; } 
        public string Name { get; set; }
        public int ChildTz { get; set; }
        public DateTime Date { get; set; }
        [ForeignKey("Parent")]
        public int PareentId { get; set; }
        //public User Parent { get; set; }

    }
}
