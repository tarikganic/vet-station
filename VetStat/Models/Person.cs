using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace VetStat.Models
{
    public class Person
    {
        [Key]
        public int Id { get; set; }

        public string? FirstName { get; set; }

        public string? LastName { get; set; }
        [Required]
        public string Email { get; set; }

        public string? Phone { get; set; }

        [ForeignKey("Role")]
        public int? RoleId { get; set; }

        [JsonIgnore]
    
        public Role? Role {get; set;}

        [JsonIgnore]
  
        public byte[]? Picture { get; set; } //Pictures are saved as memory stream

        public DateTime BirthDate { get; set; } = DateTime.Now;
        [Required]
        public string Username { get; set; }
        [Required]
        public string Password { get; set; }

        [ForeignKey("City")]
        public int? CityId { get; set; }

        [JsonIgnore]
        public City? City { get; set; }

        public DateTime ProfileCreationDate { get; set; }

        public float? MembershipLoyalty { get; set; }  //Discount     

    }
}
