using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace VetStat.Models
{
    public class Vet
    {
        [Key, ForeignKey("Person")]
        public int? Id { get; set; }

        public string Speciality { set; get; }

        public string Education { set; get; }

        public string? SpecialSkill { set; get; }
        public virtual Person? Person { get; set; }
        public virtual Employee? Employee { get; set; }
    }
}
