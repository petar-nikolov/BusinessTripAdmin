using BusinessTripAdmin.Core.ViewModels;
using BusinessTripAdmin.Infrastructure.Data.DbModels;

namespace BusinessTripAdmin.Core.Abstract
{
    public interface IUserService
    {
        Task<IEnumerable<UserList>> GetUsers();

        Task<UserEdit> GetUserForEdit(string id);

        Task<bool> UpdateUser(UserEdit userEdit);

        Task<Guid> GetOrganizationIdByUserId(string userId);

        Task<Organization> GetOrganizationById(Guid orgId);
    }
}
