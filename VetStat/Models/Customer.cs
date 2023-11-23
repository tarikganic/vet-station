using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VetStat.Models
{
    public class Customer : Person
    {

        public DateTime ProfileCreationDate { get; set; }

        public float? MembershipLoyalty { get; set; }  //Discount     

    }
}
