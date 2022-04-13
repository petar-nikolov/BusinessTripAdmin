﻿using BusinessTripAdmin.Infrastructure.Constants;
using System.ComponentModel.DataAnnotations;

namespace BusinessTripAdmin.Core.ViewModels
{
    public class EmployeeViewModel
    {
        public Guid EmployeeId { get; set; }

        [Required]
        [StringLength(ValidationConstants.EmployeeNameMaxLength)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(ValidationConstants.EmployeeNameMaxLength)]
        public string LastName { get; set; }

        [Required]
        [StringLength(ValidationConstants.PositonNameMaxLength)]
        public string PositionName { get; set; }
    }
}
