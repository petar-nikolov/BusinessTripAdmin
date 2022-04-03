using BusinessTripAdmin.Infrastructure.Data.Enums;
using System.Reflection;

namespace BusinessTripAdmin.Infrastructure
{
    public static class Helpers
    {
        public static Dictionary<string, string> ReadCountriesFromFile()
        {
            var countryNamesFileName = "Countries.txt";
            var countryNamesFilePath = GetPathByFileName(countryNamesFileName);
            var countries = new List<string>();

            using (var reader = new StreamReader(countryNamesFilePath))
            {
                var fileReadLines = reader.ReadToEnd();
                countries = fileReadLines.Trim().Replace("\n", "").Replace("\r", "").Split(",").ToList();
            }

            var countryCurrencies = new Dictionary<string, string>();

            foreach (var country in countries)
            {
                var countrySplit = country.Split("-");
                var countryName = countrySplit[0];
                var countryCurrency = countrySplit[1];
                countryCurrencies.Add(countryName, countryCurrency);
            }

            return countryCurrencies;
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
            return countryNamesFilePath;
        }
    }
}
