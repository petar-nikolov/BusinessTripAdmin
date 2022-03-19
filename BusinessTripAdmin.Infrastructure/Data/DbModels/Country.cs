using BusinessTripAdmin.Infrastructure.Constants;
using BusinessTripAdmin.Infrastructure.Data.Enums;
using System.ComponentModel.DataAnnotations;

namespace BusinessTripAdmin.Infrastructure.Data.DbModels
{
    public class Country : BaseEntity
    {
        [Required]
        [StringLength(ValidationConstants.CountryNameMaxLength)]
        public string CountryName { get; set; }

        public CurrencyCode CurrencyCode { get; set; }

        [Required]
        [StringLength(ValidationConstants.CurrencyMaxLength)]
        public string Currency { get; set; }
    }
}
