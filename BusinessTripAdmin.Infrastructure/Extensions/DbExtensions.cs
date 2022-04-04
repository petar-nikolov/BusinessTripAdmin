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

        public static Allowance GetCurrentCountryAllowance(this Country country)
        {
            var allowanceToReturn = country.Allowances.FirstOrDefault(x => x.ValidFrom <= DateTime.Today && (x.ValidTo > DateTime.Today || x.ValidTo == null));
            return allowanceToReturn;
        }
    }
}
