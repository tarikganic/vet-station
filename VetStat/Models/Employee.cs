using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using System.Diagnostics.CodeAnalysis;

namespace VetStat.Models
{
    public class Employee : Person
    {
        [Key]
        [JsonIgnore]
        public int Id { get; set; }

        public int VetstationId { get; set; }
        //public VetStation VetStationId { get; set; }

        [Required]
        public DateTime DateOfEmployment { get; set; }

        [JsonIgnore]
        [AllowNull]
        public Person? Person { get; set; }
    }
}
