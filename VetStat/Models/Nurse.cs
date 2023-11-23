using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Runtime.ConstrainedExecution;

namespace VetStat.Models
{
    public class Nurse : Employee
    {
        public string? Qualifications { get; set; }

        public string? Informations { get; set; }

    }
}
