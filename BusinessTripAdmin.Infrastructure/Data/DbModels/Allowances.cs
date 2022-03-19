namespace BusinessTripAdmin.Infrastructure.Data.DbModels
{
    public class Allowances : BaseEntity
    {
        public decimal DailyAllowance { get; set; }

        public decimal AccomodationAllowance { get; set; }

        public DateTime ValidFrom { get; set; }

        public DateTime? ValidTo { get; set; }

        public Guid CountryId { get; set; }

        public Country Country { get; set; }
    }
}
