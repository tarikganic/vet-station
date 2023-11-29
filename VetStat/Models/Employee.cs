using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using System.Diagnostics.CodeAnalysis;

namespace VetStat.Models
{
    public class Employee : Person
    {
        [Key, JsonIgnore]
        public int Id { get; set; }

        [ForeignKey("VetStation"), AllowNull]
        public int? VetStationId { get; set; }

        [JsonIgnore, AllowNull]
        public VetStation? VetStation { get; set; }

        [Required]
        public DateTime DateOfEmployment { get; set; }

        [JsonIgnore,AllowNull]
        public Person? Person { get; set; }
    }
}
