using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace VetStat.Models
{
    public class Employee
    {
        [Key]
        public int? Id { get; set; }
        
        public int VetstationId { get; set; }

        //public VetStation VetStationId { get; set; }

        [Required]
        public DateTime DateOfEmployment { get; set; }
    }
}
