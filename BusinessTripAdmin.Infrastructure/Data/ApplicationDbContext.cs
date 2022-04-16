using BusinessTripAdmin.Infrastructure.Data.DbModels;
using BusinessTripAdmin.Infrastructure.Data.Identity;
using BusinessTripAdmin.Infrastructure.Extensions;
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

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Seed();
        }

        public DbSet<Employee> Employees { get; set; }

        public DbSet<Organization> Organizations { get; set; }

        public DbSet<Country> Countries { get; set; }

        public DbSet<Position> Positions { get; set; }

        public DbSet<Allowance> Allowances { get; set; }

        public DbSet<EmployeeBusinessTrip> EmployeeBusinessTrips { get; set; }

        public DbSet<TripDetail> TripDetails { get; set; }
    }
}