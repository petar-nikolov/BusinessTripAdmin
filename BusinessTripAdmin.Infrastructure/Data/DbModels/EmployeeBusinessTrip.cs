﻿using System.ComponentModel.DataAnnotations.Schema;

namespace BusinessTripAdmin.Infrastructure.Data.DbModels
{
    public class EmployeeBusinessTrip : BaseEntity
    {
        public Country TripFrom { get; set; }

        public Country TripTo { get; set; }

        public DateTime DateFrom { get; set; }

        public DateTime DateTo { get; set; }

        public int TotalDays { get; set; }

        [ForeignKey(nameof(Employee))]
        public Guid EmployeeId { get; set; }

        public Employee Employee { get; set; }
    }
}
