using BusinessTripAdmin.Core.Abstract;
using BusinessTripAdmin.Core.ViewModels;
using BusinessTripAdmin.Infrastructure.Data.Abstraction;
using BusinessTripAdmin.Infrastructure.Data.DbModels;
using BusinessTripAdmin.Infrastructure.Data.Identity;
using Microsoft.EntityFrameworkCore;

namespace BusinessTripAdmin.Core.Services
{
    public class UserService : IUserService
    {
        private readonly IApplicationDbRepository _applicationDbRepository;

        public UserService(IApplicationDbRepository applicationDbRepository)
        {
            _applicationDbRepository = applicationDbRepository;
        }

        public async Task<Organization> GetOrganizationById(Guid orgId)
        {
            var organization = await _applicationDbRepository.GetAll<Organization>().FirstOrDefaultAsync(x => x.Id == orgId);
            if (organization == null)
            {
                throw new ArgumentException("No Organization");
            }

            return organization;
        }

        public async Task<Guid> GetOrganizationIdByUserId(string userId)
        {
            var currentUser = await _applicationDbRepository.GetAll<ApplicationUser>().FirstOrDefaultAsync(x => x.Id == userId);
            var userOrganization = currentUser?.OrganizationId;
            if (userOrganization == null)
            {
                throw new ArgumentException("No Organization");
            }

            return (Guid)userOrganization;
        }

        public async Task<UserEdit> GetUserForEdit(string id)
        {
            var user = await _applicationDbRepository.GetByIdAsync<ApplicationUser>(id);
            if(user == null)
            {
                throw new ArgumentException("No User");
            }

            return new UserEdit
            {
                Id = user.Id,
                FirstName = user.FirstName,
                LastName = user.LastName
            };
        }

        public async Task<IEnumerable<UserList>> GetUsers()
        {
            return await _applicationDbRepository.GetAll<ApplicationUser>().
                Select(x => new UserList
                {
                    Id = x.Id,
                    Email = x.Email,
                    FullName = $"{x.FirstName} {x.LastName}"
                }).ToListAsync();
        }

        public async Task<bool> UpdateUser(UserEdit userEdit)
        {
            var userToUpdate = await _applicationDbRepository.GetAll<ApplicationUser>().FirstOrDefaultAsync(x => x.Id == userEdit.Id);
            if (userToUpdate != null)
            {
                userToUpdate.FirstName = userEdit.FirstName;
                userToUpdate.LastName = userEdit.LastName;
                await _applicationDbRepository.SaveChangesAsync();
                return true;
            }

            return false;
        }
    }
}
