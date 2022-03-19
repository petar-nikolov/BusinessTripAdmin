using BusinessTripAdmin.Infrastructure.Constants;
using System.ComponentModel.DataAnnotations;

namespace BusinessTripAdmin.Infrastructure.Data.DbModels
{
    public class Organization : BaseEntity
    {
        [Required]
        [StringLength(ValidationConstants.OrganizationNameMaxLength)]
        public string OrganizationName { get; set; }

        [Required]
        [StringLength(ValidationConstants.CountryNameMaxLength)]
        public string LocalCountry { get; set; }
    }
}
