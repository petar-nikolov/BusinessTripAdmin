using BusinessTripAdmin.Infrastructure.Data.Enums;

namespace BusinessTripAdmin.Core.ViewModels
{
    public class BusinessTripViewModel
    {
        public string TripFrom { get; set; }

        public string TripTo { get; set; }

        public DateTime DateFrom { get; set; }

        public DateTime DateTo { get; set; }

        public int TotalDays { get; set; }

        public decimal TotalDailyAllowance { get; set; }

        public decimal TotalAccomodationAllowance { get; set; }

        public string TripCurrency { get; set; }

        public Guid EmployeeId { get; set; }

        public string Employee { get; set; }

        public Transport TripBy { get; set; }

        public string TransportNumber { get; set; }

        public string Purpose { get; set; }

        public Guid BusinessTripId { get; set; }
    }
}