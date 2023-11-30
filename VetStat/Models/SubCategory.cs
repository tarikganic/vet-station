using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;

namespace VetStat.Models
{
    public class SubCategory
    {
        public int Id { get; set; }
        public string Name { get; set; }

        [ForeignKey("Category")]
        public int CategoryId { get; set; }
        [JsonIgnore, AllowNull]
        public Category? Category { get; set; } 

    }
}
