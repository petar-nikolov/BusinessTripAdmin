﻿using BusinessTripAdmin.Core.Abstract;
using BusinessTripAdmin.Core.ViewModels;
using BusinessTripAdmin.Infrastructure.Data.Abstraction;
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

        public async Task<Guid> GetOrganizationByUserId(string userId)
        {
            var currentUser = await _applicationDbRepository.GetAll<ApplicationUser>().FirstOrDefaultAsync(x => x.Id == userId);
            var userOrganization = currentUser?.OrganizationId;
            if (userOrganization == null)
            {
                return Guid.Empty;
            }

            return (Guid)userOrganization;
        }

        public async Task<UserEdit> GetUserForEdit(string id)
        {
            var user = await _applicationDbRepository.GetByIdAsync<ApplicationUser>(id);
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
