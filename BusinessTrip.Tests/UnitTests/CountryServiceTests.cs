using BusinessTripAdmin.Core.Abstract;
using BusinessTripAdmin.Core.Services;
using BusinessTripAdmin.Core.ViewModels;
using BusinessTripAdmin.Infrastructure.Data.Abstraction;
using BusinessTripAdmin.Infrastructure.Data.DbModels;
using BusinessTripAdmin.Infrastructure.Data.Identity;
using BusinessTripAdmin.Infrastructure.Data.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace BusinessTrip.Tests.UnitTests
{
    [TestFixture]
    public class CountryServiceTests
    {
        private ServiceProvider _serviceProvider;
        private InMemoryDbContext _dbContext;

        [SetUp]
        public async Task Setup()
        {
            _dbContext = new InMemoryDbContext();
            var serviceCollection = new ServiceCollection();

            _serviceProvider = serviceCollection
                .AddSingleton(sp => _dbContext.CreateContext())
                .AddSingleton<IApplicationDbRepository, ApplicationDbRepository>()
                .AddSingleton<ICountryService, CountryService>()
                .AddSingleton<IUserService, UserService>()
                .BuildServiceProvider();

            var repository = _serviceProvider.GetService<IApplicationDbRepository>();
            await SeedDbAsync(repository);
        }

        [Test]
        public async Task CreateAllowanceByCountryName()
        {
            var repository = _serviceProvider.GetService<IApplicationDbRepository>();

            var country = new Country
            {
                CountryName = "CountryName",
                TripCurrency = "USD",
                LocalCurrency = "USD",
                CurrencyCode = BusinessTripAdmin.Infrastructure.Data.Enums.CurrencyCode.USD,
                Description = String.Empty,
                Id = Guid.Parse("7f088b18-dfa1-4570-b9de-55d63b116853")
            };

            await repository.AddAsync(country);
            await repository.SaveChangesAsync();

            var service = _serviceProvider.GetService<ICountryService>();

            var allowanceToCreate = new CreateAllowance
            {
                AccomodationAllowance = 10,
                DailyAllowance = 9,
                ValidFrom = DateTime.Today,
                ValidTo = null
            };

            var isCreatedAllowance = await service.CreateAllowanceByCountryName(country.CountryName, allowanceToCreate);

            Assert.True(isCreatedAllowance);

            var actualCreatedAllowance = await repository.GetAll<Allowance>().SingleOrDefaultAsync(x => x.DailyAllowance == allowanceToCreate.DailyAllowance &&
                                                                                                        x.AccomodationAllowance == allowanceToCreate.AccomodationAllowance &&
                                                                                                        x.ValidFrom == allowanceToCreate.ValidFrom &&
                                                                                                        x.ValidTo == allowanceToCreate.ValidTo);
            Assert.NotNull(actualCreatedAllowance);
        }

        [Test]
        public async Task CreateAllowanceByMissingCountryName()
        {
            var repository = _serviceProvider.GetService<IApplicationDbRepository>();

            var service = _serviceProvider.GetService<ICountryService>();

            var allowanceToCreate = new CreateAllowance
            {
                AccomodationAllowance = 10,
                DailyAllowance = 9,
                ValidFrom = DateTime.Today,
                ValidTo = null
            };

            var isCreatedAllowance = await service.CreateAllowanceByCountryName("NoSuchName", allowanceToCreate);

            Assert.False(isCreatedAllowance);

            var actualCreatedAllowance = await repository.GetAll<Allowance>().FirstOrDefaultAsync(x => x.DailyAllowance == allowanceToCreate.DailyAllowance &&
                                                                                                        x.AccomodationAllowance == allowanceToCreate.AccomodationAllowance &&
                                                                                                        x.ValidFrom == allowanceToCreate.ValidFrom &&
                                                                                                        x.ValidTo == allowanceToCreate.ValidTo);
            Assert.Null(actualCreatedAllowance);
        }

        [Test]
        public async Task CreateNewCountry()
        {
            var repository = _serviceProvider.GetService<IApplicationDbRepository>();
            var service = _serviceProvider.GetService<ICountryService>();

            var createCountry = new CreateCountry
            {
                CountryName = "New Country",
                LocalCurrency = "USD",
                TripCurrency = "USD",
                CurrencyCode = BusinessTripAdmin.Infrastructure.Data.Enums.CurrencyCode.USD,
                Description = String.Empty,
                AccomodationAllowance = 10,
                DailyAllowance = 9,
                ValidFrom = DateTime.Today,
                ValidTo = null
            };

            var isCreated = await service.CreateCountry(createCountry);
            Assert.True(isCreated);

            var actualCreatedCountry = await repository.GetAll<Country>().Include(x => x.Allowances).SingleOrDefaultAsync(x => x.CountryName == createCountry.CountryName);
            Assert.NotNull(actualCreatedCountry);
            Assert.AreEqual(createCountry.LocalCurrency, actualCreatedCountry.LocalCurrency);
            Assert.AreEqual(createCountry.TripCurrency, actualCreatedCountry.TripCurrency);
            Assert.AreEqual(createCountry.CurrencyCode, actualCreatedCountry.CurrencyCode);
            Assert.AreEqual(createCountry.Description, actualCreatedCountry.Description);

            var actualAllowance = actualCreatedCountry.Allowances.Single();
            Assert.AreEqual(createCountry.AccomodationAllowance, actualAllowance.AccomodationAllowance);
            Assert.AreEqual(createCountry.DailyAllowance, actualAllowance.DailyAllowance);
            Assert.AreEqual(createCountry.ValidFrom, actualAllowance.ValidFrom);
            Assert.AreEqual(createCountry.ValidTo, actualAllowance.ValidTo);
        }

        [TestCase("CountryName")]
        [TestCase("TripCurrency")]
        public async Task CreateNewCountryWithMissingField(string field)
        {
            var repository = _serviceProvider.GetService<IApplicationDbRepository>();
            var service = _serviceProvider.GetService<ICountryService>();

            var createCountry = new CreateCountry
            {
                CountryName = "New Country",
                LocalCurrency = "USD",
                TripCurrency = "USD",
                CurrencyCode = BusinessTripAdmin.Infrastructure.Data.Enums.CurrencyCode.USD,
                Description = String.Empty,
                AccomodationAllowance = 10,
                DailyAllowance = 9,
                ValidFrom = DateTime.Today,
                ValidTo = null
            };

            createCountry.GetType().GetProperty(field).SetValue(createCountry, null);

            var isCreated = await service.CreateCountry(createCountry);
            Assert.False(isCreated);

            var actualCreatedCountry = await repository.GetAll<Country>().Include(x => x.Allowances).SingleOrDefaultAsync(x => x.CountryName == createCountry.CountryName);
        }

        [Test]
        public async Task EditCountry()
        {
            var repository = _serviceProvider.GetService<IApplicationDbRepository>();
            var service = _serviceProvider.GetService<ICountryService>();

            var createCountry = new Country
            {
                CountryName = "New Country",
                LocalCurrency = "USD",
                TripCurrency = "USD",
                CurrencyCode = BusinessTripAdmin.Infrastructure.Data.Enums.CurrencyCode.USD,
                Description = String.Empty,
                Id = Guid.NewGuid()
            };

            await repository.AddAsync(createCountry);
            await repository.SaveChangesAsync();

            var editCountry = new EditCountry
            {
                CountryName = "Updated",
                Description = "Updated",
                LocalCurrency = "BGN",
                TripCurrency = "EUR",
                CurrencyCode = BusinessTripAdmin.Infrastructure.Data.Enums.CurrencyCode.EUR,
            };

            var isUpdated = await service.EditCountry(createCountry.Id, editCountry);
            Assert.True(isUpdated);

            var actualUpdatedCountry = await repository.GetAll<Country>().AsNoTracking().FirstOrDefaultAsync(x => x.Id == createCountry.Id);
            Assert.NotNull(actualUpdatedCountry);
            Assert.AreEqual(editCountry.CountryName, actualUpdatedCountry.CountryName);
            Assert.AreEqual(editCountry.LocalCurrency, actualUpdatedCountry.LocalCurrency);
            Assert.AreEqual(editCountry.TripCurrency, actualUpdatedCountry.TripCurrency);
            Assert.AreEqual(editCountry.CurrencyCode, actualUpdatedCountry.CurrencyCode);
        }

        [Test]
        public async Task EditMissingCountry()
        {
            var repository = _serviceProvider.GetService<IApplicationDbRepository>();
            var service = _serviceProvider.GetService<ICountryService>();

            var createCountry = new Country
            {
                CountryName = "New Country",
                LocalCurrency = "USD",
                TripCurrency = "USD",
                CurrencyCode = BusinessTripAdmin.Infrastructure.Data.Enums.CurrencyCode.USD,
                Description = String.Empty,
                Id = Guid.NewGuid()
            };

            await repository.AddAsync(createCountry);
            await repository.SaveChangesAsync();

            var editCountry = new EditCountry
            {
                CountryName = "Updated",
                Description = "Updated",
                LocalCurrency = "BGN",
                TripCurrency = "EUR",
                CurrencyCode = BusinessTripAdmin.Infrastructure.Data.Enums.CurrencyCode.EUR,
            };

            var isUpdated = await service.EditCountry(Guid.NewGuid(), editCountry);
            Assert.False(isUpdated);

            var actualUpdatedCountry = await repository.GetAll<Country>().AsNoTracking().FirstOrDefaultAsync(x => x.Id == createCountry.Id);
            Assert.NotNull(actualUpdatedCountry);
            Assert.AreNotEqual(editCountry.CountryName, actualUpdatedCountry.CountryName);
            Assert.AreNotEqual(editCountry.LocalCurrency, actualUpdatedCountry.LocalCurrency);
            Assert.AreNotEqual(editCountry.TripCurrency, actualUpdatedCountry.TripCurrency);
            Assert.AreNotEqual(editCountry.CurrencyCode, actualUpdatedCountry.CurrencyCode);
        }

        [Test]
        public async Task GetAllCountries()
        {
            var repository = _serviceProvider.GetService<IApplicationDbRepository>();
            var service = _serviceProvider.GetService<ICountryService>();

            var country1 = new Country
            {
                CountryName = "New Country1",
                LocalCurrency = "AUD",
                TripCurrency = "USD",
                CurrencyCode = BusinessTripAdmin.Infrastructure.Data.Enums.CurrencyCode.USD,
                Description = String.Empty,
                Id = Guid.NewGuid()
            };

            await repository.AddAsync(country1);
            var country2 = new Country
            {
                CountryName = "New Country2",
                LocalCurrency = "EUR",
                TripCurrency = "USD",
                CurrencyCode = BusinessTripAdmin.Infrastructure.Data.Enums.CurrencyCode.JPY,
                Description = String.Empty,
                Id = Guid.NewGuid()
            };

            await repository.AddAsync(country2);
            await repository.SaveChangesAsync();

            var countriesReturned = await service.GetAllCountries();

            Assert.AreEqual(2, countriesReturned.Count());
        }

        [Test]
        public async Task GetEmptyCountries()
        {
            var service = _serviceProvider.GetService<ICountryService>();

            var countriesReturned = await service.GetAllCountries();

            Assert.AreEqual(0, countriesReturned.Count());
        }

        [Test]
        public async Task GetCountryAllowances()
        {
            var repository = _serviceProvider.GetService<IApplicationDbRepository>();
            var service = _serviceProvider.GetService<ICountryService>();

            var country1 = new Country
            {
                CountryName = "New Country1",
                LocalCurrency = "AUD",
                TripCurrency = "USD",
                CurrencyCode = BusinessTripAdmin.Infrastructure.Data.Enums.CurrencyCode.USD,
                Description = String.Empty,
                Id = Guid.NewGuid()
            };

            await repository.AddAsync(country1);

            var country2 = new Country
            {
                CountryName = "New Country2",
                LocalCurrency = "EUR",
                TripCurrency = "USD",
                CurrencyCode = BusinessTripAdmin.Infrastructure.Data.Enums.CurrencyCode.JPY,
                Description = String.Empty,
                Id = Guid.NewGuid()
            };

            await repository.AddAsync(country2);

            var allowances1 = new List<Allowance>();
            allowances1.Add(new Allowance
            {
                AccomodationAllowance = 1,
                DailyAllowance = 1,
                ValidFrom = DateTime.Today,
                ValidTo = null,
            });
            allowances1.Add(new Allowance
            {
                AccomodationAllowance = 2,
                DailyAllowance = 2,
                ValidFrom = DateTime.Today.AddMonths(-12),
                ValidTo = DateTime.Today.AddDays(-1),
            });

            allowances1.ForEach(x => country1.Allowances.Add(x));

            country2.Allowances.Add(new Allowance
            {
                AccomodationAllowance = 3,
                DailyAllowance = 3,
                ValidFrom = DateTime.Today.AddMonths(-12),
                ValidTo = DateTime.Today.AddDays(-1),
            });

            await repository.AddAsync(country1);
            await repository.AddAsync(country2);
            await repository.SaveChangesAsync();

            var allowancesReturned = await service.GetAllCountryAllowancesByCountryName(country1.CountryName);
            Assert.AreEqual(2, allowancesReturned.Count());
        }

        [Test]
        public async Task GetCountryAllowancesForMissingCountry()
        {
            var repository = _serviceProvider.GetService<IApplicationDbRepository>();
            var service = _serviceProvider.GetService<ICountryService>();

            var country1 = new Country
            {
                CountryName = "New Country1",
                LocalCurrency = "AUD",
                TripCurrency = "USD",
                CurrencyCode = BusinessTripAdmin.Infrastructure.Data.Enums.CurrencyCode.USD,
                Description = String.Empty,
                Id = Guid.NewGuid()
            };

            var allowances1 = new List<Allowance>();
            allowances1.Add(new Allowance
            {
                AccomodationAllowance = 1,
                DailyAllowance = 1,
                ValidFrom = DateTime.Today,
                ValidTo = null,
            });

            allowances1.ForEach(x => country1.Allowances.Add(x));
            await repository.AddAsync(country1);
            await repository.SaveChangesAsync();

            var allowancesReturned = await service.GetAllCountryAllowancesByCountryName("Missing");
            Assert.AreEqual(0, allowancesReturned.Count());
        }

        [Test]
        public async Task GetSingleCountry()
        {
            var repository = _serviceProvider.GetService<IApplicationDbRepository>();
            var service = _serviceProvider.GetService<ICountryService>();

            var country1 = new Country
            {
                CountryName = "New Country1",
                LocalCurrency = "AUD",
                TripCurrency = "USD",
                CurrencyCode = BusinessTripAdmin.Infrastructure.Data.Enums.CurrencyCode.USD,
                Description = String.Empty,
                Id = Guid.NewGuid()
            };

            var allowances1 = new List<Allowance>();
            allowances1.Add(new Allowance
            {
                AccomodationAllowance = 1,
                DailyAllowance = 1,
                ValidFrom = DateTime.Today,
                ValidTo = null,
            });

            allowances1.ForEach(x => country1.Allowances.Add(x));
            await repository.AddAsync(country1);
            await repository.SaveChangesAsync();

            var countryReturned = await service.GetCountryById(country1.Id);
            Assert.NotNull(countryReturned);
            Assert.AreEqual(country1.CountryName, countryReturned.CountryName);
            Assert.AreEqual(country1.Id, countryReturned.Id);
        }

        [Test]
        public async Task GetMissingCountry()
        {
            var service = _serviceProvider.GetService<ICountryService>();

            Assert.CatchAsync<ArgumentException>(async () => await service.GetCountryById(Guid.NewGuid()));
        }

        private async Task SeedDbAsync(IApplicationDbRepository applicationDbRepository)
        {
            var organization = new Organization
            {
                OrganizationName = "TestOrganization",
                Id = Guid.Parse("02198db7-2872-4f70-9a65-08287515a0f6"),
                LocalCountry = "Bulgaria"
            };

            var users = new List<ApplicationUser>();
            var user = new ApplicationUser
            {
                Id = "272ae641-f5c7-4493-ad3f-3415322df772",
                EmailConfirmed = true,
                PhoneNumberConfirmed = true,
                LockoutEnabled = false,
                AccessFailedCount = 0,
                OrganizationId = organization.Id,
                FirstName = "TestFirstName",
                LastName = "TestLastName"
            };

            users.Add(user);

            await applicationDbRepository.AddAsync(organization);
            await applicationDbRepository.AddRangeAsync(users);
            await applicationDbRepository.SaveChangesAsync();
        }

        [TearDown]
        public async Task Dispose()
        {
            await _serviceProvider.DisposeAsync();
        }
    }
}
