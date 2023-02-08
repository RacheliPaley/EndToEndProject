using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApi.models
{
    public class ChildModel
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int ChildTz { get; set; }
        public DateTime Date { get; set; }
        //[ForeignKey("Parent")]
        public int PareentId { get; set; }
        //public UserModel Parent { get; set; }
    }
}
