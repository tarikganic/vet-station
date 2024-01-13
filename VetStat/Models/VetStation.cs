using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;

namespace VetStat.Models
{
  
    public class VetStation
    {
        [Key]
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




    }
}
