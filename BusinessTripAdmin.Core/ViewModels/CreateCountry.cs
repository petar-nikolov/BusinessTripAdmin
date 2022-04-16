using BusinessTripAdmin.Infrastructure.Constants;
using BusinessTripAdmin.Infrastructure.Data.Enums;
using System.ComponentModel.DataAnnotations;

namespace BusinessTripAdmin.Core.ViewModels
{
    public class CreateCountry
    {
        [Required]
        [StringLength(ValidationConstants.CountryNameMaxLength)]
        public string CountryName { get; set; }

        [Required]
        public CurrencyCode CurrencyCode { get; set; }

        [Required]
        [StringLength(ValidationConstants.CurrencyMaxLength)]
        public string TripCurrency { get; set; }

        [StringLength(ValidationConstants.CurrencyMaxLength)]
        public string? LocalCurrency { get; set; }

        [StringLength(ValidationConstants.DescriptionMaxLength)]
        public string? Description { get; set; }

        [Required]
        public decimal DailyAllowance { get; set; }

        public decimal AccomodationAllowance { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "yyyy-MM-dd", ApplyFormatInEditMode = true)]
        public DateTime ValidFrom { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "yyyy-MM-dd", ApplyFormatInEditMode = true)]
        public DateTime? ValidTo { get; set; }
    }
}
