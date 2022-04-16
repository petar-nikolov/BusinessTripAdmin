using BusinessTripAdmin.Infrastructure.Data.DbModels;
using BusinessTripAdmin.Infrastructure.Data.Enums;
using System.Reflection;

namespace BusinessTripAdmin.Infrastructure
{
    public static class Helpers
    {
        public static IDictionary<Country, Allowance> ReadCountriesFromFile()
        {
            var countryNamesFileName = "Countries.txt";
            var countryNamesFilePath = GetPathByFileName(countryNamesFileName);
            if (countryNamesFilePath == String.Empty)
            {
                return new Dictionary<Country, Allowance>();
            }
            var splitCountryInfo = new List<string>();

            using (var reader = new StreamReader(countryNamesFilePath))
            {
                var fileReadLines = reader.ReadToEnd();
                splitCountryInfo = fileReadLines.Trim().Replace("\n", "").Replace("\r", "").Split(",").ToList();
            }

            var countries = new Dictionary<Country, Allowance>();

            foreach (var countryInfo in splitCountryInfo)
            {
                var countrySplit = countryInfo.Split("-");
                var countryName = countrySplit[0];
                var countryCurrency = countrySplit[1];
                var allowancePerDay = decimal.Parse(countrySplit[2]);
                var accomodation = decimal.Parse(countrySplit[3]);

                var country = new Country
                {
                    CountryName = countryName,
                    TripCurrency = countryCurrency,
                    CurrencyCode = GetCurrencyCodeByCurrencyName(countryCurrency),
                };

                var allowance = new Allowance
                {
                    Id = Guid.NewGuid(),
                    DailyAllowance = allowancePerDay,
                    AccomodationAllowance = accomodation,
                    ValidFrom = DateTime.Today,
                    ValidTo = null,
                    CountryId = country.Id
                };
                countries.Add(country, allowance);
            }

            return countries;
        }

        public static CurrencyCode GetCurrencyCodeByCurrencyName(string currencyName)
        {
            CurrencyCode currencyCode;

            switch (currencyName)
            {
                case "US Dollar":
                    currencyCode = CurrencyCode.USD;
                    break;

                case "Euro":
                    currencyCode = CurrencyCode.EUR;
                    break;

                case "Swiss Franc":
                    currencyCode = CurrencyCode.CHF;
                    break;

                case "Yen":
                    currencyCode = CurrencyCode.JPY;
                    break;

                case "Australian Dollar":
                    currencyCode = CurrencyCode.AUD;
                    break;

                case "Pound Sterling":
                    currencyCode = CurrencyCode.GBP;
                    break;

                default:
                    currencyCode = CurrencyCode.USD;
                    break;
            }

            return currencyCode;
        }

        private static string GetPathByFileName(string fileName)
        {
            var baseDirectory = Environment.CurrentDirectory;
            var uri = new UriBuilder(baseDirectory);
            var path = Path.GetDirectoryName(Uri.UnescapeDataString(uri.Path));
            var currentProject = Assembly.GetCallingAssembly().GetName().Name;
            var countryNamesFilePath = @$"{path}\{currentProject}\Constants\{fileName}";
            if (baseDirectory.Contains("BusinessTrip.Tests"))
            {
                return String.Empty;
            }
            return countryNamesFilePath;
        }
    }
}
