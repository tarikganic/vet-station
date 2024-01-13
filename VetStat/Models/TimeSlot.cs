﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;

namespace VetStat.Models
{
    public class TimeSlot
    {
        [Key]
        public int Id { get;set; }

        //

        [ForeignKey("Availability"), AllowNull]
        public int? AvailabilityId { get; set; }
        [JsonIgnore, AllowNull]
        public Availability? Availability { get; set; }

        //

        public DateTime SlotDateTime { get; set; }

        //

        [ForeignKey("Employee"),AllowNull]
        public int? SlotEmployeeId { get; set; }
        [JsonIgnore, AllowNull]
        public Employee? Employee { get; set; }

        //

        [Required]
        public bool IsAvailable { get; set; }
    }
}
