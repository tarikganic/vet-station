using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;

namespace VetStat.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        public string? ProductName { get; set; }
        public string? Manufacturer { get; set; }
        public string? Description { get; set; }

        [ForeignKey("SubCategory")]
        public int SubCategoryId { get; set; }

        [JsonIgnore, AllowNull]
        public ICollection<SubCategory>? SubCategories { get; set; } = new List<SubCategory>(); //it has a same function as -> public SubCategory SubCategory
        
        public string? SideEffects { get; set; }
        public byte[]? Image { get; set; } //picture



    }
}
