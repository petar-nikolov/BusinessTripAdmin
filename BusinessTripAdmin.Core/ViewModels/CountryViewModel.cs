using BusinessTripAdmin.Infrastructure.Data.Enums;

namespace BusinessTripAdmin.Core.ViewModels
{
    public class CountryViewModel
    {
        public string? CountryName { get; set; }

        public CurrencyCode CurrencyCode { get; set; }

        public string? TripCurrency { get; set; }

        public string? LocalCurrency { get; set; }

        public string? Description { get; set; }

        public decimal DailyAllowance { get; set; }

        public decimal AccomodationAllowance { get; set; }
    }
}
