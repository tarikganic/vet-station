using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;

namespace VetStat.Models
{
    public class Animal
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string? Name { get; set; }

        [ForeignKey("Customer")]
        public int? OwnerId { get; set; }

        [JsonIgnore]
   

        public Customer? Customer { get; set; }

        // public Person Id {get;set;}
        public DateTime BirthDate {get;set; }
        [ForeignKey("Species")]

        public int? AnimalSpeciesId { get; set; }
        [JsonIgnore]

        public Species? Species { get; set; }
        public byte[]? Picture { get; set; }
        public byte[]? MedicalFile { get;set; }
    }
}
