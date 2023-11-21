using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace VetStat.Models
{
    public class Barber
    {
        [Key, ForeignKey("Person")]
        public int? Id { get; set; }

        public byte[]? Certification { get; set; } //e.g. PDF file
        public virtual Person? Person { get; set; }
        public virtual Employee? Employee { get; set; }

    }
}
