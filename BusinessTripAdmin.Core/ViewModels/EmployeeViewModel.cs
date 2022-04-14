using BusinessTripAdmin.Infrastructure.Constants;
using System.ComponentModel.DataAnnotations;

namespace BusinessTripAdmin.Core.ViewModels
{
    public class EmployeeViewModel
    {
        public Guid OrganizationId { get; set; } 

        public Guid EmployeeId { get; set; }

        public string FirstName { get; set; }

        public string MiddleName { get; set; }

        public string LastName { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "yyyy-MM-dd", ApplyFormatInEditMode = true)]
        public DateTime BirthDate { get; set; }

        public string PositionName { get; set; }

        public bool IsActive { get; set; }
    }
}
