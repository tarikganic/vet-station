using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VetStat.Models
{
    public class Customer
    {
        [Key, ForeignKey("Person")]
        public int? Id { get; set; }

        public DateTime ProfileCreationDate { get; set; }

        public float? MembershipLoyalty { get; set; }  //Discount
        
        public virtual Person? Person { get; set; }


    }
}
