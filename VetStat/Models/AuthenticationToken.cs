using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VetStat.Models
{
    public class AuthentificationToken
    {
        [Key]
        public int Id { get; set; }

        public string Token { get; set; }

        [ForeignKey(nameof(UserProfile))]
        public int UserProfileId { get; set; }
        public Person UserProfile { get; set; }

        public string? IpAdress { get; set; }

        public DateTime? LoggTime { get; set; }
    }
}
