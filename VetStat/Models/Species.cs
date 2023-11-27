using System.ComponentModel.DataAnnotations;

namespace VetStat.Models
{
    public class Species
    {
        [Key]
        public int Id { get; set; }
        public string? SpeciesName { get; set; }
        public string? Behavior { get; set; }
        public string? PredatorsAndThreats { get; set; }
        public string? ScientificName { get; set; }
        public string? Diet { get; set; }
    }
}
