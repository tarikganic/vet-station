using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;
using Microsoft.EntityFrameworkCore;

namespace VetStat.Models
{
    public class VetStation
    {
        [Key]
        public int Id { get; set; }
        public string? Name { get; set; }
        [ForeignKey("City")]
        public int CityId { get; set; }

        [JsonIgnore]
        public City? City { get; set; }
        public string ContactNumber { get; set; }

        [JsonIgnore]
        public ICollection<Employee> Employees { get; set; } = new List<Employee>();
       
        public int? MainVetId { get; set; }

        [JsonIgnore]
        public MainVet? MainVet { get; set; }
    }
}
