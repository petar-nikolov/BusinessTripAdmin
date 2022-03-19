﻿using BusinessTripAdmin.Infrastructure.Constants;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BusinessTripAdmin.Infrastructure.Data.DbModels
{
    public class EmployeeBusinessTrip : BaseEntity
    {
        [Required]
        [StringLength(ValidationConstants.CountryNameMaxLength)]
        public string TripFrom { get; set; }

        [Required]
        [StringLength(ValidationConstants.CountryNameMaxLength)]
        public string TripTo { get; set; }

        public DateTime DateFrom { get; set; }

        public DateTime DateTo { get; set; }

        public int TotalDays { get; set; }

        [ForeignKey(nameof(Employee))]
        public Guid EmployeeId { get; set; }

        public Employee Employee { get; set; }
    }
}
