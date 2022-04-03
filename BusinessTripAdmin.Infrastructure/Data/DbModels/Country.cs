using BusinessTripAdmin.Infrastructure.Constants;
using BusinessTripAdmin.Infrastructure.Data.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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

        [ForeignKey(nameof(Allowance))]
        public Guid AllowanceId { get; set; }

        public Allowance Allowance { get; set; }
    }
}