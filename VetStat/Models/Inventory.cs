using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using System.Net.Http.Headers;
using System.Text.Json.Serialization;

namespace VetStat.Models
{
    public class Inventory
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("VetStation")]
        public int VetStationId { get; set; }

        [JsonIgnore]        
        public VetStation? VetStation { get; set; }
        [ForeignKey("Product")]
        public int ProductId { get; set; }
        [JsonIgnore]
        public Product? Product { get; set; }
        public int Quantity { get; set; }
        public DateTime DateOfEntry { get; set; } //When it arrived in the inventory
        public DateTime ProductionDate { get; set; }
        public DateTime ExpireDate { get; set; }
        public string Status { get; set; }
        public float SellingPrice { get; set; }


    }
}
