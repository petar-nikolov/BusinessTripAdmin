using BusinessTripAdmin.Core.Abstract;
using BusinessTripAdmin.Core.ViewModels;
using BusinessTripAdmin.Infrastructure.Data.Abstraction;
using BusinessTripAdmin.Infrastructure.Data.Identity;
using Microsoft.EntityFrameworkCore;

namespace BusinessTripAdmin.Core.Services
{
    public class UserService : IUserService
    {
        private readonly IApplicatioDbRepository _applicatioDbRepository;

        public UserService(IApplicatioDbRepository applicatioDbRepository)
        {
            _applicatioDbRepository = applicatioDbRepository;
        }

        public async Task<UserEdit> GetUserForEdit(string id)
        {
            var user = await _applicatioDbRepository.GetByIdAsync<ApplicationUser>(id);
            return new UserEdit
            {
                Id = user.Id,
                FirstName = user.FirstName,
                LastName = user.LastName
            };
        }

        public async Task<IEnumerable<UserList>> GetUsers()
        {
            return await _applicatioDbRepository.GetAll<ApplicationUser>().
                Select(x => new UserList
                {
                    Id = x.Id,
                    Email = x.Email,
                    FullName = $"{x.FirstName} {x.LastName}"
                }).ToListAsync();
        }
    }
}
