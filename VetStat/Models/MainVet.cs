using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;

namespace VetStat.Models
{
    public class MainVet : Vet
    {
        [JsonIgnore]
        public VetStation ChiefVetStation { get; set; }

        [ForeignKey("VetStation")]
        public int ChiefVetStationId { get; set; }
    }
}
