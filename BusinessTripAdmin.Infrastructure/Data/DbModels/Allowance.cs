using System.ComponentModel.DataAnnotations.Schema;

namespace BusinessTripAdmin.Infrastructure.Data.DbModels
{
    public class Allowance : BaseEntity
    {
        public decimal DailyAllowance { get; set; }

        public decimal AccomodationAllowance { get; set; }

        public DateTime ValidFrom { get; set; }

        public DateTime? ValidTo { get; set; }

        [ForeignKey(nameof(Country))]
        public Guid CountryId { get; set; }

        public Country Country { get; set; }
    }
}
