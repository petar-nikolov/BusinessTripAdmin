using BusinessTripAdmin.Infrastructure.Data.Enums;

namespace BusinessTripAdmin.Infrastructure.Data.DbModels
{
    public class Country : BaseEntity
    {
        public string CountryName { get; set; }

        public CurrencyCode CurrencyCode { get; set; }

        public string Currency { get; set; }
    }
}
