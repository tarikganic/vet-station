using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VetStat.Models
{
    public class VetStation
    {
        [Key]
        public int Id { get; set; } //waiting for Amil to make the MainVet model!
        public string? Name { get; set; }
        [ForeignKey("City")]
        public int CityId { get; set; }
        public City City { get; set; }
        public string ContactNumber { get; set; }  
    }
}
