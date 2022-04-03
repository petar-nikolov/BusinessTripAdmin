using BusinessTripAdmin.Infrastructure.Data.DbModels;
using Microsoft.EntityFrameworkCore;


namespace BusinessTripAdmin.Infrastructure.Extensions
{
    public static class DbExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            var countriesFromFile = Helpers.ReadCountriesFromFile();
            var countiesToImport = new List<Country>();

            foreach (var readCountry in countriesFromFile)
            {
                var countryName = readCountry.Key;
                var countryCurrencyName = readCountry.Value;
                var countryCurrencyCode = Helpers.GetCurrencyCodeByCurrencyName(countryCurrencyName);
                countiesToImport.Add(new Country
                {
                    CountryName = countryName,
                    Currency = countryCurrencyName,
                    CurrencyCode = countryCurrencyCode
                });
            }

            foreach (var country in countiesToImport)
            {
                modelBuilder.Entity<Country>().HasData(country);
            }
        }
    }
}
