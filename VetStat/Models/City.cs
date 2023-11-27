using System.ComponentModel.DataAnnotations;

namespace VetStat.Models
{
    public class City
    {
        [Key]
        public int Id { get; set; }

        public string? CityName { get; set; }
        public string? ZipCode { get; set; }
        public string? Country { get; set; }
        public string? Continent { get; set; }
    }
}
