using BusinessTripAdmin.Infrastructure.Data.DbModels;
using BusinessTripAdmin.Infrastructure.Data.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BusinessTripAdmin.Infrastructure.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Employee> Employees { get; set; }

        public DbSet<Organization> Organizations { get; set; }

        public DbSet<Country> Countries { get; set; }

        public DbSet<Position> Positions { get; set; }

        public DbSet<Allowance> Allowances { get; set; }

        public DbSet<EmployeeBusinessTrip> EmployeeBusinessTrips { get; set; }
    }
}