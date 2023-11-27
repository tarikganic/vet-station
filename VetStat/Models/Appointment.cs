using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VetStat.Models
{
    public class Appointment
    {
        [Key]
        public int Id { get; set; }

        //

        [ForeignKey("Customer"), Required]
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }

        //

        [ForeignKey("VetStation"), Required]
        public int VetStationId {get;set;}
        public VetStation VetStation { get; set; }

        // public ICollection<VetStation> VetStations { get; set; } = new List<VetStation>();

        [ForeignKey("Employee"),Required]
        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }

        //

        [ForeignKey("TimeSlot"), Required]
        public int TimeSlotId { get; set; }
        public TimeSlot TimeSlot { get; set; }

        //

        [ForeignKey("Animal"), Required]
        public int AnimalId { get; set; }
        public Animal Animal { get; set; }

    }
}
