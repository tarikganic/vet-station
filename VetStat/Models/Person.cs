using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VetStat.Models
{
    public class Person
    {
        [Key]
        public int Id { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Email { get; set; }

        public string Phone { get; set; }

        [ForeignKey("Role")]
        public int RoleId { get; set; }

        public Role Role {get; set;}

        public byte[] Picture { get; set; } //Pictures are saved as memory stream

        public DateTime BirthDate { get; set; }

        public string Username { get; set; }

        public string Password { get; set; }

        [ForeignKey("City")]
        public int CityId { get; set; }

        //public City City { get; set; }

    }
}
