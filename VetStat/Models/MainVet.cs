using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;

namespace VetStat.Models
{
    public class MainVet : Vet
    {
<<<<<<< HEAD
        [JsonIgnore]
        public VetStation? ChiefVetStation { get; set; }


        [ForeignKey("VetStation")]
        public int ChiefVetStationId { get; set; }
=======
>>>>>>> fa890ea34b87cf98e471ba6db46df610178a1c03
    }
}
