using BusinessTripAdmin.Infrastructure.Constants;
using BusinessTripAdmin.Infrastructure.Data.Enums;
using System.ComponentModel.DataAnnotations;

namespace BusinessTripAdmin.Infrastructure.Data.DbModels
{
    public class TripDetail : BaseEntity
    {
        public Transport TripBy { get; set; }

        [StringLength(ValidationConstants.TransportNumberMaxLength)]
        public string? TransportNumber { get; set; }
    }
}
