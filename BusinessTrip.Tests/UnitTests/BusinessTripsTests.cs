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
    public class BusinessTripsTests
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
                .AddSingleton<IBusinessTripService, BusinessTripService>()
                .AddSingleton<IEmployeeService, EmployeeService>()
                .AddSingleton<ICountryService, CountryService>()
                .AddSingleton<IUserService, UserService>()
                .BuildServiceProvider();

            var repository = _serviceProvider.GetService<IApplicationDbRepository>();
            await SeedDbAsync(repository);
        }

        [Test]
        public async Task CreateBusinessTripWithCorrectData()
        {
            var repository = _serviceProvider.GetService<IApplicationDbRepository>();
            var service = _serviceProvider.GetService<IBusinessTripService>();

            var employees = new List<string>();

            employees.Add("c20d4003-ffb6-46a7-afec-6e27acf4635e");

            var createBusinessTrip = new CreateBusinessTrip
            {
                DateFrom = DateTime.Now.Date,
                DateTo = DateTime.Now.Date.AddDays(9),
                TripFrom = "New Country1",
                TripTo = "New Country2",
                Purpose = "TestPurposse",
                TripBy = BusinessTripAdmin.Infrastructure.Data.Enums.Transport.AirPlane,
                TransportNumber = "12sdsgf03e",
                Employees = employees
            };

            var isCreated = await service.CreateBusinessTrip(createBusinessTrip);
            Assert.True(isCreated);
            var addedTrip = await repository.GetAll<EmployeeBusinessTrip>().Include(x => x.TripDetail).FirstOrDefaultAsync(x => x.TripFrom == createBusinessTrip.TripFrom &&
                                                                                                                                x.TripTo == createBusinessTrip.TripTo &&
                                                                                                                                x.Purpose == createBusinessTrip.Purpose);
            Assert.NotNull(addedTrip);
            Assert.AreEqual(createBusinessTrip.TransportNumber, addedTrip.TripDetail.TransportNumber);
        }

        [Test]
        public async Task GetAllExistingTrips()
        {
            var service = _serviceProvider.GetService<IBusinessTripService>();

            var employees = new List<string>();

            employees.Add("c20d4003-ffb6-46a7-afec-6e27acf4635e");

            var createBusinessTrip = new CreateBusinessTrip
            {
                DateFrom = DateTime.Now.Date,
                DateTo = DateTime.Now.Date.AddDays(9),
                TripFrom = "New Country1",
                TripTo = "New Country2",
                Purpose = "TestPurposse",
                TripBy = BusinessTripAdmin.Infrastructure.Data.Enums.Transport.AirPlane,
                TransportNumber = "12sdsgf03e",
                Employees = employees
            };

            var isCreated = await service.CreateBusinessTrip(createBusinessTrip);
            Assert.True(isCreated);
            var createBusinessTrip2 = new CreateBusinessTrip
            {
                DateFrom = DateTime.Now.Date.AddDays(10),
                DateTo = DateTime.Now.Date.AddDays(19),
                TripFrom = "New Country2",
                TripTo = "New Country1",
                Purpose = "TestPurposse2",
                TripBy = BusinessTripAdmin.Infrastructure.Data.Enums.Transport.AirPlane,
                TransportNumber = "dsagfdhfghdfgh",
                Employees = employees
            };

            await service.CreateBusinessTrip(createBusinessTrip2);
            var allTrips = await service.GelAllTrips("272ae641-f5c7-4493-ad3f-3415322df772");
            Assert.True(allTrips.Any());
        }

        [Test]
        public async Task CheckGettingDataForCreation()
        {
            var service = _serviceProvider.GetService<IBusinessTripService>();
            var data = await service.GetDataForCreateAsync("272ae641-f5c7-4493-ad3f-3415322df772");
            Assert.True(data.Item1.Any());
            Assert.True(data.Item2.Any());
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


            var country1 = new Country
            {
                CountryName = "New Country1",
                LocalCurrency = "AUD",
                TripCurrency = "USD",
                CurrencyCode = BusinessTripAdmin.Infrastructure.Data.Enums.CurrencyCode.USD,
                Description = String.Empty,
                Id = Guid.NewGuid()
            };

            await applicationDbRepository.AddAsync(country1);

            var country2 = new Country
            {
                CountryName = "New Country2",
                LocalCurrency = "EUR",
                TripCurrency = "USD",
                CurrencyCode = BusinessTripAdmin.Infrastructure.Data.Enums.CurrencyCode.JPY,
                Description = String.Empty,
                Id = Guid.NewGuid()
            };

            await applicationDbRepository.AddAsync(country2);

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

            var first = new Employee
            {
                BirthDate = DateTime.Today.AddYears(-30),
                FirstName = "Will",
                LastName = "Smith",
                MiddleName = "Active",
                IsActive = true,
                OrganizationId = Guid.Parse("02198db7-2872-4f70-9a65-08287515a0f6"),
                PositionName = "QA",
                Id = Guid.Parse("c20d4003-ffb6-46a7-afec-6e27acf4635e")
            };

            await applicationDbRepository.AddAsync(first);
            await applicationDbRepository.AddAsync(country1);
            await applicationDbRepository.AddAsync(country2);
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
