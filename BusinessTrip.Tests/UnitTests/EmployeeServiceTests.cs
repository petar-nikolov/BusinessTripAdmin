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
    public class EmployeeServiceTests
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
                .AddSingleton<IEmployeeService, EmployeeService>()
                .AddSingleton<IUserService, UserService>()
                .BuildServiceProvider();

            var repository = _serviceProvider.GetService<IApplicationDbRepository>();
            await SeedDbAsync(repository);
        }

        [Test]
        public async Task ActivateExistingDeactivatedEmployee()
        {
            var repository = _serviceProvider.GetService<IApplicationDbRepository>();

            var employeeToActivate = new Employee
            {
                BirthDate = DateTime.Today.AddYears(-30),
                FirstName = "Will",
                LastName = "Smith",
                MiddleName = "NotActive",
                IsActive = false,
                OrganizationId = Guid.Parse("02198db7-2872-4f70-9a65-08287515a0f6"),
                PositionName = "QA",
                Id = Guid.Parse("e1f61e6a-3e2e-4119-b518-7f88aef7bd96")
            };

            var employee2 = new Employee
            {
                BirthDate = DateTime.Today.AddYears(-30),
                FirstName = "Al",
                LastName = "Pacino",
                MiddleName = "Active",
                IsActive = true,
                OrganizationId = Guid.Parse("02198db7-2872-4f70-9a65-08287515a0f6"),
                PositionName = "Dev",
                Id = Guid.Parse("a75c09ba-2167-4ec3-9667-0353e413b838")
            };

            await repository.AddAsync(employeeToActivate);
            await repository.AddAsync(employee2);
            await repository.SaveChangesAsync();

            var service = _serviceProvider.GetService<IEmployeeService>();

            await service.ActivateEmployee(employeeToActivate.Id);

            var employees = await repository.GetAll<Employee>().AsNoTracking().ToListAsync();
            var activatedEmployee = employees.FirstOrDefault(x => x.Id == employeeToActivate.Id);
            Assert.True(activatedEmployee.IsActive);
            Assert.AreEqual(2, await repository.GetAll<Employee>().AsNoTracking().CountAsync(x => x.IsActive));
        }

        [Test]
        public async Task ActivateExistingActivatedEmployee()
        {
            var repository = _serviceProvider.GetService<IApplicationDbRepository>();

            var employee1 = new Employee
            {
                BirthDate = DateTime.Today.AddYears(-30),
                FirstName = "Will",
                LastName = "Smith",
                MiddleName = "NotActive",
                IsActive = false,
                OrganizationId = Guid.Parse("02198db7-2872-4f70-9a65-08287515a0f6"),
                PositionName = "QA",
                Id = Guid.Parse("e1f61e6a-3e2e-4119-b518-7f88aef7bd96")
            };

            var employee2 = new Employee
            {
                BirthDate = DateTime.Today.AddYears(-30),
                FirstName = "Al",
                LastName = "Pacino",
                MiddleName = "Active",
                IsActive = true,
                OrganizationId = Guid.Parse("02198db7-2872-4f70-9a65-08287515a0f6"),
                PositionName = "Dev",
                Id = Guid.Parse("a75c09ba-2167-4ec3-9667-0353e413b838")
            };

            await repository.AddAsync(employee1);
            await repository.AddAsync(employee2);
            await repository.SaveChangesAsync();

            var service = _serviceProvider.GetService<IEmployeeService>();

            await service.ActivateEmployee(employee2.Id);

            var employees = await repository.GetAll<Employee>().AsNoTracking().ToListAsync();
            var activatedEmployee = employees.FirstOrDefault(x => x.Id == employee2.Id);
            Assert.True(activatedEmployee.IsActive);
            Assert.AreEqual(1, await repository.GetAll<Employee>().AsNoTracking().CountAsync(x => x.IsActive));
        }

        [Test]
        public async Task ActivateMissingEmployee()
        {
            var repository = _serviceProvider.GetService<IApplicationDbRepository>();

            var employee1 = new Employee
            {
                BirthDate = DateTime.Today.AddYears(-30),
                FirstName = "Will",
                LastName = "Smith",
                MiddleName = "NotActive",
                IsActive = false,
                OrganizationId = Guid.Parse("02198db7-2872-4f70-9a65-08287515a0f6"),
                PositionName = "QA",
                Id = Guid.Parse("e1f61e6a-3e2e-4119-b518-7f88aef7bd96")
            };

            await repository.AddAsync(employee1);
            await repository.SaveChangesAsync();

            var service = _serviceProvider.GetService<IEmployeeService>();

            var isActivated = await service.ActivateEmployee(Guid.NewGuid());

            var employees = await repository.GetAll<Employee>().AsNoTracking().ToListAsync();
            Assert.False(isActivated);
            Assert.AreEqual(0, await repository.GetAll<Employee>().AsNoTracking().CountAsync(x => x.IsActive));
        }

        [Test]
        public async Task CreateNewEmployee()
        {
            var createEmployee = new CreateEmployee
            {
                BirthDate = DateTime.Today.AddYears(-30),
                FirstName = "Will",
                LastName = "Smith",
                MiddleName = "NotActive",
                PositionName = "QA",
            };

            var service = _serviceProvider.GetService<IEmployeeService>();
            var isCreated = await service.CreateEmployee(createEmployee, "272ae641-f5c7-4493-ad3f-3415322df772");
            var repository = _serviceProvider.GetService<IApplicationDbRepository>();

            var actualCreatedEmployee = await repository.GetAll<Employee>().SingleOrDefaultAsync(x => x.FirstName == createEmployee.FirstName &&
                                                                                                x.LastName == createEmployee.LastName &&
                                                                                                x.BirthDate == createEmployee.BirthDate &&
                                                                                                x.PositionName == createEmployee.PositionName);
            Assert.True(isCreated);
            Assert.True(actualCreatedEmployee.IsActive);
            Assert.NotNull(actualCreatedEmployee);

        }

        [TestCase("FirstName")]
        [TestCase("LastName")]
        [TestCase("MiddleName")]
        [TestCase("PositionName")]
        public async Task CreateNewEmployeeWithMissingRequiredField(string field)
        {
            var createEmployee = new CreateEmployee
            {
                BirthDate = DateTime.Today.AddYears(-30),
                FirstName = "Will",
                LastName = "Smith",
                MiddleName = "NotActive",
                PositionName = "QA",
            };

            createEmployee.GetType().GetProperty(field).SetValue(createEmployee, null);

            var service = _serviceProvider.GetService<IEmployeeService>();
            var isCreated = await service.CreateEmployee(createEmployee, "272ae641-f5c7-4493-ad3f-3415322df772");
            var repository = _serviceProvider.GetService<IApplicationDbRepository>();

            var actualCreatedEmployee = repository.GetAll<Employee>().FirstOrDefault(x => x.FirstName == createEmployee.FirstName &&
                                                                                                x.LastName == createEmployee.LastName &&
                                                                                                x.BirthDate == createEmployee.BirthDate &&
                                                                                                x.PositionName == createEmployee.PositionName);
            Assert.False(isCreated);
            Assert.Null(actualCreatedEmployee);
        }

        [Test]
        public async Task DeactivateExistingActiveEmployee()
        {
            var repository = _serviceProvider.GetService<IApplicationDbRepository>();

            var employee = new Employee
            {
                BirthDate = DateTime.Today.AddYears(-30),
                FirstName = "Will",
                LastName = "Smith",
                MiddleName = "NotActive",
                IsActive = false,
                OrganizationId = Guid.Parse("02198db7-2872-4f70-9a65-08287515a0f6"),
                PositionName = "QA",
                Id = Guid.Parse("e1f61e6a-3e2e-4119-b518-7f88aef7bd96")
            };

            var employeeToDeactivate = new Employee
            {
                BirthDate = DateTime.Today.AddYears(-30),
                FirstName = "Al",
                LastName = "Pacino",
                MiddleName = "Active",
                IsActive = true,
                OrganizationId = Guid.Parse("02198db7-2872-4f70-9a65-08287515a0f6"),
                PositionName = "Dev",
                Id = Guid.Parse("a75c09ba-2167-4ec3-9667-0353e413b838")
            };

            await repository.AddAsync(employeeToDeactivate);
            await repository.AddAsync(employee);
            await repository.SaveChangesAsync();

            var service = _serviceProvider.GetService<IEmployeeService>();

            await service.DeactivateEmployee(employeeToDeactivate.Id);

            var employees = await repository.GetAll<Employee>().AsNoTracking().ToListAsync();
            var deactivatedEmployee = employees.FirstOrDefault(x => x.Id == employeeToDeactivate.Id);
            Assert.False(deactivatedEmployee.IsActive);
            Assert.AreEqual(2, await repository.GetAll<Employee>().AsNoTracking().CountAsync(x => !x.IsActive));
        }

        [Test]
        public async Task DectivateExistingDeactivatedEmployee()
        {
            var repository = _serviceProvider.GetService<IApplicationDbRepository>();

            var employee2 = new Employee
            {
                BirthDate = DateTime.Today.AddYears(-30),
                FirstName = "Will",
                LastName = "Smith",
                MiddleName = "NotActive",
                IsActive = false,
                OrganizationId = Guid.Parse("02198db7-2872-4f70-9a65-08287515a0f6"),
                PositionName = "QA",
                Id = Guid.Parse("e1f61e6a-3e2e-4119-b518-7f88aef7bd96")
            };

            var employee1 = new Employee
            {
                BirthDate = DateTime.Today.AddYears(-30),
                FirstName = "Al",
                LastName = "Pacino",
                MiddleName = "Active",
                IsActive = true,
                OrganizationId = Guid.Parse("02198db7-2872-4f70-9a65-08287515a0f6"),
                PositionName = "Dev",
                Id = Guid.Parse("a75c09ba-2167-4ec3-9667-0353e413b838")
            };

            await repository.AddAsync(employee1);
            await repository.AddAsync(employee2);
            await repository.SaveChangesAsync();

            var service = _serviceProvider.GetService<IEmployeeService>();

            await service.DeactivateEmployee(employee2.Id);

            var employees = await repository.GetAll<Employee>().AsNoTracking().ToListAsync();
            var deactivatedEmployee = employees.FirstOrDefault(x => x.Id == employee2.Id);
            Assert.False(deactivatedEmployee.IsActive);
            Assert.AreEqual(1, await repository.GetAll<Employee>().AsNoTracking().CountAsync(x => !x.IsActive));
        }

        [Test]
        public async Task DectivateMissingEmployee()
        {
            var repository = _serviceProvider.GetService<IApplicationDbRepository>();

            var employee1 = new Employee
            {
                BirthDate = DateTime.Today.AddYears(-30),
                FirstName = "Will",
                LastName = "Smith",
                MiddleName = "Active",
                IsActive = true,
                OrganizationId = Guid.Parse("02198db7-2872-4f70-9a65-08287515a0f6"),
                PositionName = "QA",
                Id = Guid.Parse("e1f61e6a-3e2e-4119-b518-7f88aef7bd96")
            };

            await repository.AddAsync(employee1);
            await repository.SaveChangesAsync();

            var service = _serviceProvider.GetService<IEmployeeService>();

            var isDeactivated = await service.DeactivateEmployee(Guid.NewGuid());

            var employees = await repository.GetAll<Employee>().AsNoTracking().ToListAsync();
            Assert.False(isDeactivated);
            Assert.AreEqual(0, await repository.GetAll<Employee>().AsNoTracking().CountAsync(x => !x.IsActive));
        }

        [Test]
        public async Task EditEmployee()
        {
            var employeeToEdit = new Employee
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
            var repository = _serviceProvider.GetService<IApplicationDbRepository>();
            await repository.AddAsync(employeeToEdit);
            await repository.SaveChangesAsync();

            var editEmployee = new CreateEmployee
            {
                BirthDate = DateTime.Today.AddYears(-50),
                FirstName = "WillUpdated",
                LastName = "SmithUpdated",
                MiddleName = "Updated",
                PositionName = "QA",
            };

            var service = _serviceProvider.GetService<IEmployeeService>();
            var isUpdated = await service.EditEmployee(editEmployee, Guid.Parse("c20d4003-ffb6-46a7-afec-6e27acf4635e"));

            var actualUpdatedEmployee = await repository.GetAll<Employee>().SingleOrDefaultAsync(x => x.FirstName == editEmployee.FirstName &&
                                                                                                x.LastName == editEmployee.LastName &&
                                                                                                x.BirthDate == editEmployee.BirthDate &&
                                                                                                x.PositionName == editEmployee.PositionName);
            Assert.True(isUpdated);
            Assert.NotNull(actualUpdatedEmployee);
        }

        [TestCase("FirstName")]
        [TestCase("LastName")]
        [TestCase("MiddleName")]
        [TestCase("PositionName")]
        public async Task EditNewEmployeeWithMissingRequiredField(string field)
        {
            var employeeToEdit = new Employee
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
            var repository = _serviceProvider.GetService<IApplicationDbRepository>();
            await repository.AddAsync(employeeToEdit);
            await repository.SaveChangesAsync();

            var editEmployee = new CreateEmployee
            {
                BirthDate = DateTime.Today.AddYears(-30),
                FirstName = "WillUpdated",
                LastName = "SmithUpdated",
                MiddleName = "Updated",
                PositionName = "Updated",
            };

            editEmployee.GetType().GetProperty(field).SetValue(editEmployee, null);

            var service = _serviceProvider.GetService<IEmployeeService>();
            var isCreated = await service.EditEmployee(editEmployee, Guid.Parse("c20d4003-ffb6-46a7-afec-6e27acf4635e"));

            var actualCreatedEmployee = await repository.GetAll<Employee>().FirstOrDefaultAsync(x => x.FirstName == editEmployee.FirstName &&
                                                                                                x.LastName == editEmployee.LastName &&
                                                                                                x.BirthDate == editEmployee.BirthDate &&
                                                                                                x.PositionName == editEmployee.PositionName);
            Assert.False(isCreated);
            Assert.Null(actualCreatedEmployee);
        }

        [Test]
        public async Task GetOnlyActiveEmployeesByOrganization()
        {
            var repository = _serviceProvider.GetService<IApplicationDbRepository>();

            var active = new Employee
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
            await repository.AddAsync(active);

            var inActive = new Employee
            {
                BirthDate = DateTime.Today.AddYears(-30),
                FirstName = "NotActive",
                LastName = "NotActive",
                MiddleName = "NotActive",
                IsActive = false,
                OrganizationId = Guid.Parse("02198db7-2872-4f70-9a65-08287515a0f6"),
                PositionName = "QA",
                Id = Guid.Parse("8f6cd943-7081-4ae2-b4e2-158452bffd65")
            };
            await repository.AddAsync(inActive);

            await repository.SaveChangesAsync();

            var service = _serviceProvider.GetService<IEmployeeService>();

            var activeEmployees = await service.GetActiveEmployeesByOrganizationId(Guid.Parse("02198db7-2872-4f70-9a65-08287515a0f6"));

            Assert.IsNotEmpty(activeEmployees);
            Assert.True(activeEmployees.All(x => x.IsActive));
        }

        [Test]
        public async Task GetEmptyListOfActiveEmployeesByOrganizationWhenMissing()
        {
            var repository = _serviceProvider.GetService<IApplicationDbRepository>();

            var active = new Employee
            {
                BirthDate = DateTime.Today.AddYears(-30),
                FirstName = "Will",
                LastName = "Smith",
                MiddleName = "Active",
                IsActive = false,
                OrganizationId = Guid.Parse("02198db7-2872-4f70-9a65-08287515a0f6"),
                PositionName = "QA",
                Id = Guid.Parse("c20d4003-ffb6-46a7-afec-6e27acf4635e")
            };
            await repository.AddAsync(active);

            var inActive = new Employee
            {
                BirthDate = DateTime.Today.AddYears(-30),
                FirstName = "NotActive",
                LastName = "NotActive",
                MiddleName = "NotActive",
                IsActive = false,
                OrganizationId = Guid.Parse("02198db7-2872-4f70-9a65-08287515a0f6"),
                PositionName = "QA",
                Id = Guid.Parse("8f6cd943-7081-4ae2-b4e2-158452bffd65")
            };
            await repository.AddAsync(inActive);

            await repository.SaveChangesAsync();

            var service = _serviceProvider.GetService<IEmployeeService>();

            var activeEmployees = await service.GetActiveEmployeesByOrganizationId(Guid.Parse("02198db7-2872-4f70-9a65-08287515a0f6"));

            Assert.IsEmpty(activeEmployees);
        }

        [Test]
        public async Task GetEmptyWhenWrongOrg()
        {
            var repository = _serviceProvider.GetService<IApplicationDbRepository>();

            var active = new Employee
            {
                BirthDate = DateTime.Today.AddYears(-30),
                FirstName = "Will",
                LastName = "Smith",
                MiddleName = "Active",
                IsActive = false,
                OrganizationId = Guid.Parse("02198db7-2872-4f70-9a65-08287515a0f6"),
                PositionName = "QA",
                Id = Guid.Parse("c20d4003-ffb6-46a7-afec-6e27acf4635e")
            };
            await repository.AddAsync(active);

            var inActive = new Employee
            {
                BirthDate = DateTime.Today.AddYears(-30),
                FirstName = "NotActive",
                LastName = "NotActive",
                MiddleName = "NotActive",
                IsActive = false,
                OrganizationId = Guid.Parse("02198db7-2872-4f70-9a65-08287515a0f6"),
                PositionName = "QA",
                Id = Guid.Parse("8f6cd943-7081-4ae2-b4e2-158452bffd65")
            };
            await repository.AddAsync(inActive);

            await repository.SaveChangesAsync();

            var service = _serviceProvider.GetService<IEmployeeService>();

            var activeEmployees = await service.GetActiveEmployeesByOrganizationId(Guid.NewGuid());
            Assert.IsEmpty(activeEmployees);
        }

        [Test]
        public async Task GetAllEmployees()
        {
            var repository = _serviceProvider.GetService<IApplicationDbRepository>();

            var first = new Employee
            {
                BirthDate = DateTime.Today.AddYears(-30),
                FirstName = "Will",
                LastName = "Smith",
                MiddleName = "Active",
                IsActive = false,
                OrganizationId = Guid.Parse("02198db7-2872-4f70-9a65-08287515a0f6"),
                PositionName = "QA",
                Id = Guid.Parse("c20d4003-ffb6-46a7-afec-6e27acf4635e")
            };
            await repository.AddAsync(first);

            var second = new Employee
            {
                BirthDate = DateTime.Today.AddYears(-30),
                FirstName = "NotActive",
                LastName = "NotActive",
                MiddleName = "NotActive",
                IsActive = false,
                OrganizationId = Guid.Parse("02198db7-2872-4f70-9a65-08287515a0f6"),
                PositionName = "QA",
                Id = Guid.Parse("8f6cd943-7081-4ae2-b4e2-158452bffd65")
            };
            await repository.AddAsync(second);

            await repository.SaveChangesAsync();

            var service = _serviceProvider.GetService<IEmployeeService>();

            var allEmployees = await service.GetAllEmployees();
            Assert.IsNotEmpty(allEmployees);
            Assert.True(allEmployees.Count() == 2);
        }

        [Test]
        public async Task GetAllEmployeesWhenEmpty()
        {
            var service = _serviceProvider.GetService<IEmployeeService>();

            var allEmployees = await service.GetAllEmployees();
            Assert.IsEmpty(allEmployees);
        }

        [Test]
        public async Task GetEmployeeById()
        {
            var repository = _serviceProvider.GetService<IApplicationDbRepository>();

            var first = new Employee
            {
                BirthDate = DateTime.Today.AddYears(-30),
                FirstName = "Will",
                LastName = "Smith",
                MiddleName = "Active",
                IsActive = false,
                OrganizationId = Guid.Parse("02198db7-2872-4f70-9a65-08287515a0f6"),
                PositionName = "QA",
                Id = Guid.Parse("c20d4003-ffb6-46a7-afec-6e27acf4635e")
            };
            await repository.AddAsync(first);

            await repository.SaveChangesAsync();

            var service = _serviceProvider.GetService<IEmployeeService>();

            var actualEmployee = await service.GetEmployeeById(Guid.Parse("c20d4003-ffb6-46a7-afec-6e27acf4635e"));

            Assert.AreEqual(first.FirstName, actualEmployee.FirstName);
            Assert.AreEqual(first.LastName, actualEmployee.LastName);
            Assert.AreEqual(first.MiddleName, actualEmployee.MiddleName);
        }

        [Test]
        public async Task GetMissingEmployee()
        {
            var service = _serviceProvider.GetService<IEmployeeService>();

            Assert.CatchAsync<ArgumentException>(async () => await service.GetEmployeeById(Guid.NewGuid()));

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
