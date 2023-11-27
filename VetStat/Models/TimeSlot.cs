using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VetStat.Models
{
    public class TimeSlot
    {
        [Key]
        public int Id { get;set; }

        //

        [ForeignKey("Availability")]
        public int AvailabilityId { get; set; }
        public Availability Availability { get; set; }

        //

        public DateTime SlotDateTime { get; set; }

        //

        [ForeignKey("Employee")]
        public int SlotEmployeeId { get; set; }
        public Employee Employee { get; set; }

        //

        [Required]
        public bool IsAvailable { get; set; }
    }
}
