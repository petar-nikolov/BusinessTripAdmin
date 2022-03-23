using BusinessTripAdmin.Core.ViewModels;
using BusinessTripAdmin.Infrastructure.Data.Identity;

namespace BusinessTripAdmin.Core.Abstract
{
    public interface IUserService
    {
        Task<IEnumerable<UserList>> GetUsers();

        Task<UserEdit> GetUserForEdit(string id);

        Task<bool> UpdateUser(UserEdit userEdit);

        //Task<ApplicationUser> GetApplicationUser(string id);
    }
}
