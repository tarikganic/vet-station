using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace VetStat.Models
{
    public class Vet : Employee
    {
        public string Speciality { set; get; }

        public string Education { set; get; }

        public string? SpecialSkill { set; get; }

    }
}
