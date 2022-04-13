using BusinessTripAdmin.Infrastructure.Constants;
using BusinessTripAdmin.Infrastructure.Data.Enums;
using System.ComponentModel.DataAnnotations;

namespace BusinessTripAdmin.Core.ViewModels
{
    public class EditCountry
    {
        [Required]
        [StringLength(ValidationConstants.CountryNameMaxLength)]
        public string CountryName { get; set; }

        public CurrencyCode CurrencyCode { get; set; }

        [Required]
        [StringLength(ValidationConstants.CurrencyMaxLength)]
        public string TripCurrency { get; set; }

        [StringLength(ValidationConstants.CurrencyMaxLength)]
        public string? LocalCurrency { get; set; }

        [StringLength(ValidationConstants.DescriptionMaxLength)]
        public string? Description { get; set; }

        public string OldCountryName { get; set; }

        public CurrencyCode OldCurrencyCode { get; set; }

        public string OldTripCurrency { get; set; }

        public string? OldLocalCurrency { get; set; }

        public string? OldDescription { get; set; }
    }
}