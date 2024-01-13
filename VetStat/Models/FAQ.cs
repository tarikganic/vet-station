using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;

namespace VetStat.Models
{
    public class FAQ
    {
        [Key]
        public int Id { get; set; }
        public string Question { get; set; }
        public string Answer { get; set; }
        
        [ForeignKey("VetStation")]
        public int VetStationId { get; set; }
        [JsonIgnore, AllowNull]
        public VetStation? VetStation { get; set; }

    }
}
