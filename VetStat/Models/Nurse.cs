using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace VetStat.Models
{
    public class Nurse
    {
        [Key, ForeignKey("Person")]
        public int? Id { get; set; }

        public string Qualifications { get; set; }

        public string? Informations { get; set; }

        public virtual Person? Person { get; set; }

        public virtual Employee? Employee { get; set; }

    }
}
