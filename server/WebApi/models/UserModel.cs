using System.ComponentModel.DataAnnotations;

namespace WebApi.models
{
    public class UserModel
    {
        [Key]
        public int Id { get; set; }
        public string Tz { get; set; }
        public string Fname { get; set; }

        public string Lname { get; set; }

        public DateTime DateOfBirdth { get; set; }

        public string Min { get; set; }
        public string Hmo { get; set; }
    }
}
