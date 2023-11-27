using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VetStat.Models
{
    public class Animal
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string? Name { get; set; }

        [ForeignKey("Customer"), Required]
        public int OwnerId { get; set; }
        public Customer Customer { get; set; }

        // public Person Id {get;set;}
        public DateTime BirthDate {get;set; }
        [ForeignKey ("Species")]
        public int AnimalSpeciesId { get; set; }

        public Species Species { get; set; }
        public byte[]? Picture { get; set; }
        public byte[]? MedicalFile { get;set; }
    }
}
