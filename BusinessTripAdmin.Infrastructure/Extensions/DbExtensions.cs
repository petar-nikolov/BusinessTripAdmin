using BusinessTripAdmin.Infrastructure.Data.DbModels;
using Microsoft.EntityFrameworkCore;


namespace BusinessTripAdmin.Infrastructure.Extensions
{
    public static class DbExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            var countriesFromFile = Helpers.ReadCountriesFromFile();

            foreach (var countryAllowance in countriesFromFile)
            {
                modelBuilder.Entity<Allowance>().HasData(countryAllowance.Value);
                modelBuilder.Entity<Country>().HasData(countryAllowance.Key);
            }
        }
    }
}
