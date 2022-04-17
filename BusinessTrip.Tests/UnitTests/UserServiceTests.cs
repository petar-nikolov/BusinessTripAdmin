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
    public class UserServiceTests
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
                .AddSingleton<IUserService, UserService>()
                .BuildServiceProvider();

            var repository = _serviceProvider.GetService<IApplicationDbRepository>();
            await SeedDbAsync(repository);
        }

        [Test]
        public async Task CheckIfOrganizationIsReturned()
        {
            var service = _serviceProvider.GetService<IUserService>();
            var org = await service.GetOrganizationById(Guid.Parse("02198db7-2872-4f70-9a65-08287515a0f6"));
            Assert.IsNotNull(org);
        }

        [Test]
        public async Task CheckIfOrganizationIfReturnedWhenOrgIsMissing()
        {
            var service = _serviceProvider.GetService<IUserService>();
            Assert.CatchAsync<ArgumentException>(async () => await service.GetOrganizationById(Guid.NewGuid()));
        }

        [Test]
        public async Task GetOrganizationByUserIdWithMissingUser()
        {
            var service = _serviceProvider.GetService<IUserService>();
            Assert.CatchAsync<ArgumentException>(async () => await service.GetOrganizationIdByUserId(Guid.NewGuid().ToString()));
        }

        [Test]
        public async Task CheckIfOrganizationIsReturnedByUserId()
        {
            var service = _serviceProvider.GetService<IUserService>();
            var org = await service.GetOrganizationIdByUserId("272ae641-f5c7-4493-ad3f-3415322df772");
            Assert.IsNotNull(org);
        }

        [Test]
        public async Task GetUserForEditShouldNotReturnUserIfMissing()
        {
            var service = _serviceProvider.GetService<IUserService>();
            Assert.CatchAsync<ArgumentException>(async () => await service.GetUserForEdit(Guid.NewGuid().ToString()));
        }

        [Test]
        public async Task GetUserForEditShouldReturnUser()
        {
            var service = _serviceProvider.GetService<IUserService>();
            var org = await service.GetUserForEdit("272ae641-f5c7-4493-ad3f-3415322df772");
            Assert.IsNotNull(org);
        }

        [Test]
        public async Task ReturnAllUsers()
        {
            var service = _serviceProvider.GetService<IUserService>();
            var users = await service.GetUsers();
            Assert.AreEqual(2, users.Count());
        }

        [Test]
        public async Task ReturnAllUsersWhenTableIsEmpty()
        {
            var service = _serviceProvider.GetService<IUserService>();
            var repository = _serviceProvider.GetService<IApplicationDbRepository>();
            var usersToDelete = await repository.GetAll<ApplicationUser>().ToListAsync();
            repository.DeleteRange(usersToDelete);
            await repository.SaveChangesAsync();
            var usersToReturn = await service.GetUsers();
            Assert.AreEqual(0, usersToReturn.Count());
        }

        [Test]
        public async Task UpdateUser()
        {
            var service = _serviceProvider.GetService<IUserService>();
            var expectedUserEdit = new UserEdit
            {
                Id = "272ae641-f5c7-4493-ad3f-3415322df772",
                FirstName = "UpdatedFirstName",
                LastName = "TestLastName"
            };
            var repository = _serviceProvider.GetService<IApplicationDbRepository>();
            var isUpdated = await service.UpdateUser(expectedUserEdit);

            var users = repository.GetAll<ApplicationUser>().AsNoTracking();
            var edittedUser = await users.FirstAsync(x => x.Id == "272ae641-f5c7-4493-ad3f-3415322df772");
            Assert.AreEqual(expectedUserEdit.FirstName, edittedUser.FirstName);
            Assert.AreEqual(expectedUserEdit.LastName, edittedUser.LastName);
            Assert.AreEqual(1, await users.CountAsync(x => x.FirstName.Contains("Updated")));
            Assert.True(isUpdated);
        }

        [Test]
        public async Task UpdateMissingUser()
        {
            var service = _serviceProvider.GetService<IUserService>();
            var expectedUserEdit = new UserEdit
            {
                Id = Guid.NewGuid().ToString(),
                FirstName = "UpdatedFirstName",
                LastName = "TestLastName"
            };
            var repository = _serviceProvider.GetService<IApplicationDbRepository>();
            var isUpdated = await service.UpdateUser(expectedUserEdit);

            var users = repository.GetAll<ApplicationUser>().AsNoTracking();
            Assert.AreEqual(0, await users.CountAsync(x => x.FirstName.Contains("Updated")));
            Assert.False(isUpdated);
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

            var user2 = new ApplicationUser
            {
                Id = "cec35a7d-88e8-4ff6-b403-c65524a735f1",
                EmailConfirmed = true,
                PhoneNumberConfirmed = true,
                LockoutEnabled = false,
                AccessFailedCount = 0,
                OrganizationId = organization.Id,
                FirstName = "TestFirstName2",
                LastName = "TestLastName2"
            };

            users.Add(user);
            users.Add(user2);

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
