﻿using BusinessTripAdmin.Infrastructure.Constants;
using System.ComponentModel.DataAnnotations;

namespace BusinessTripAdmin.Core.ViewModels
{
    public class EmployeeViewModel
    {
        public Guid OrganizationId { get; set; } 

        public Guid EmployeeId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string PositionName { get; set; }
    }
}
