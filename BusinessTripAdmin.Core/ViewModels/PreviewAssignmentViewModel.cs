using BusinessTripAdmin.Infrastructure.Constants;
using BusinessTripAdmin.Infrastructure.Data.Enums;
using System.ComponentModel.DataAnnotations;

namespace BusinessTripAdmin.Core.ViewModels
{
    public class PreviewAssignmentViewModel
    {
        [Required]
        [StringLength(200)]
        public string EmployeeFullNameCyrillic { get; set; }

        public string EmployeeFullName { get; set; }

        public string Position { get; set; }

        public string Purpose { get; set; }

        [Required]
        [StringLength(200)]
        public string TripToCyrillic { get; set; }

        public string TripTo { get; set; }

        public DateTime FromDate { get; set; }

        public DateTime ToDate { get; set; }

        public int TotalDays { get; set; }

        [Required]
        [StringLength(200)]
        public string TripByCyrillic { get; set; }

        public string TripBy { get; set; }

        public decimal DailyAllowance { get; set; }

        public decimal AccomodationAllowance { get; set; }

        public string OrganizationName { get; set; }

        public CurrencyCode CurrencyCode { get; set; }

        public string TransportNumber { get; set; }

        [Required]
        [StringLength(200)]
        public string PurposeCyrillic { get; set; }
    }
}
