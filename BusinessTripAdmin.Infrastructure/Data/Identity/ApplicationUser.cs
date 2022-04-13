using BusinessTripAdmin.Infrastructure.Constants;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace BusinessTripAdmin.Infrastructure.Data.Identity
{
    public class ApplicationUser : IdentityUser
    {
        [StringLength(ValidationConstants.EmployeeNameMaxLength)]
        public string? FirstName { get; set; }

        [StringLength(ValidationConstants.EmployeeNameMaxLength)]
        public string? LastName { get; set; }

        public Guid OrganizationId { get; set; }
    }
}
