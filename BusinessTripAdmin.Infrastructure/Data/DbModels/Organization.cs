namespace BusinessTripAdmin.Infrastructure.Data.DbModels
{
    public class Organization : BaseEntity
    {
        public string OrganizationName { get; set; }

        public string LocalCountry { get; set; }
    }
}
