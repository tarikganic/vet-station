using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace VetStat.Models
{
    public class Person
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string? FirstName { get; set; }

        [Required]
        public string? LastName { get; set; }

        public string? Email { get; set; }

        public string? Phone { get; set; }

        [ForeignKey("Role")]
        public int? RoleId { get; set; }

        [JsonIgnore]
    
        public Role? Role {get; set;}

        [JsonIgnore]
  
        public byte[]? Picture { get; set; } //Pictures are saved as memory stream

        public DateTime BirthDate { get; set; } = DateTime.Now;

        public string? Username { get; set; }

        public string? Password { get; set; }

        [ForeignKey("City")]
        public int? CityId { get; set; }

        [JsonIgnore]
        public City? City { get; set; }

    }
}
