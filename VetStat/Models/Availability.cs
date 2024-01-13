using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;

namespace VetStat.Models
{
    public class Availability
    {
        [Key]
        public int Id { get; set; }

        //

        [ForeignKey("Employee"), AllowNull]
        public int? EmployeeId { get; set; }

        [JsonIgnore, AllowNull]
        public Employee? Employee { get; set; }

        //

        public DateTime Date { get; set; }
        public DateTime AvailableFrom { get; set; }
        public DateTime AvailableTo { get; set; }
        public int AppointmentDuration { get; set; } // number of minutes or seconds

    }
}
