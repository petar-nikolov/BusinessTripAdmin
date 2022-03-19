namespace BusinessTripAdmin.Infrastructure.Data.DbModels
{
    public class Organization : BaseEntity
    {
        public string OrganizationName { get; set; }

        public Country LocalCountry { get; set; }
    }
}
