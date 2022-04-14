﻿using BusinessTripAdmin.Core.ViewModels;

namespace BusinessTripAdmin.Core.Abstract
{
    public interface IUserService
    {
        Task<IEnumerable<UserList>> GetUsers();

        Task<UserEdit> GetUserForEdit(string id);

        Task<bool> UpdateUser(UserEdit userEdit);

        Task<Guid> GetOrganizationByUserId(string userId);
    }
}
