using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;

namespace VetStat.Models
{
    public class Appointment
    {
        [Key]
        public int Id { get; set; }

        //

        [ForeignKey("Customer")]
        public int? CustomerId { get; set; }

        [JsonIgnore]
        public Customer? Customer { get; set; }

        //

        [ForeignKey("VetStation")]
        public int? VetStationId {get;set;}
        [JsonIgnore, AllowNull]
        public VetStation? VetStation { get; set; }

        // public ICollection<VetStation> VetStations { get; set; } = new List<VetStation>();

        [ForeignKey("Employee")]
        public int? EmployeeId { get; set; }
        [JsonIgnore]
        public Employee? Employee { get; set; }

        //

        [ForeignKey("TimeSlot")]
        public int? TimeSlotId { get; set; }
        [JsonIgnore]
        public TimeSlot? TimeSlot { get; set; }

        //

        [ForeignKey("Animal")]
        public int? AnimalId { get; set; }
        [JsonIgnore]
        public Animal? Animal { get; set; }

    }
}
