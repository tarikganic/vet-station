using Microsoft.EntityFrameworkCore;
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
<<<<<<< HEAD
        public int Id { get; set; } 
        public string? Name { get; set; }
        [ForeignKey("City")]
        public int? CityId { get; set; }
        [JsonIgnore,AllowNull]
        public City? City { get; set; }
        public string ContactNumber { get; set; } 

        //Service types and accommodation
        public bool IsInOffice { get; set; } = false; //false -> default

        public bool IsOnField { get; set; } = false;

        public bool Parking { get; set; } = false;

        public bool Wheelchair { get; set; } = false;

        public bool Wifi { get; set; } = false;




=======
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
>>>>>>> fa890ea34b87cf98e471ba6db46df610178a1c03
    }
}
