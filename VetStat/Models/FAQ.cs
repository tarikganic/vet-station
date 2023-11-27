using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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
        public VetStation VetStation { get; set; }

    }
}
