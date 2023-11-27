using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VetStat.Models
{
    public class Availability
    {
        [Key]
        public int Id { get; set; }

        //

        [ForeignKey("Employee"), Required]
        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }

        //

        public DateTime Date { get; set; }
        public DateTime AvailableFrom { get; set; }
        public DateTime AvailableTo { get; set; }
        public int AppointmentDuration { get; set; } // number of minutes or seconds

    }
}
