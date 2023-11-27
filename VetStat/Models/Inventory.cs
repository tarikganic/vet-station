using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Net.Http.Headers;

namespace VetStat.Models
{
    public class Inventory
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("Product")]
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public string Quantity { get; set; }
        public DateTime DateOfEntry { get; set; } //When it arrived in the inventory
        public DateTime ProductionDate { get; set; }
        public DateTime ExpireDate { get; set; }
        public string Status { get; set; }
        public float SellingPrice { get; set; }


    }
}
