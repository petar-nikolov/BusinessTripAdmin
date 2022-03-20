using BusinessTripAdmin.Core.ViewModels;

namespace BusinessTripAdmin.Core.Abstract
{
    public interface IUserService
    {
        Task<IEnumerable<UserList>> GetUsers();

        Task<UserEdit> GetUserForEdit(string id);
    }
}
