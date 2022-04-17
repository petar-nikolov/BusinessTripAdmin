using BusinessTripAdmin.Infrastructure.Constants;
using System.ComponentModel.DataAnnotations;

namespace BusinessTripAdmin.Core.ViewModels
{
    public class CreateEmployee
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

        [DataType(DataType.Date)]
        [Required]
        [DisplayFormat(DataFormatString = "yyyy-MM-dd", ApplyFormatInEditMode = true)]
        public DateTime BirthDate { get; set; }

        [Required]
        [StringLength(ValidationConstants.PositonNameMaxLength)]
        public string PositionName { get; set; }
    }
}
