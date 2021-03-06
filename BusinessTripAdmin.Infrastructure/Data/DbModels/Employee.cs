using BusinessTripAdmin.Infrastructure.Constants;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BusinessTripAdmin.Infrastructure.Data.DbModels
{
    public class Employee : BaseEntity
    {
        [Required]
        [StringLength(ValidationConstants.EmployeeNameMaxLength)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(ValidationConstants.EmployeeNameMaxLength)]
        public string MiddleName { get; set; }

        [Required]
        [StringLength(ValidationConstants.EmployeeNameMaxLength)]
        public string LastName { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "yyyy-MM-dd", ApplyFormatInEditMode = true)]
        public DateTime BirthDate { get; set; }

        public bool IsActive { get; set; }

        [Required]
        [StringLength(ValidationConstants.PositonNameMaxLength)]
        public string PositionName { get; set; }

        [ForeignKey(nameof(Organization))]
        public Guid OrganizationId { get; set; }

        public Organization Organization { get; set; }
    }
}
