using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;

namespace VetStat.Models
{
    public class VetStation
    {
        [Key]
        public int Id { get; set; } //waiting for Amil to make the MainVet model!
        public string? Name { get; set; }
        [ForeignKey("City")]
        public int CityId { get; set; }
        [JsonIgnore,AllowNull]
        public City? City { get; set; }
        public string ContactNumber { get; set; }  
    }
}
