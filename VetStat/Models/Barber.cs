using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace VetStat.Models
{
    public class Barber : Employee
    {
        public byte[]? Certification { get; set; } //e.g. PDF file


    }
}
