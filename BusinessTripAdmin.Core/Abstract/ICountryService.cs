﻿using BusinessTripAdmin.Core.ViewModels;
using BusinessTripAdmin.Infrastructure.Data.DbModels;

namespace BusinessTripAdmin.Core.Abstract
{
    public interface ICountryService
    {
        Task<IEnumerable<CountryViewModel>> GetAllCountries();

        Task<Allowance> GetCurrentCountryAllowance(Guid countryId);
    }
}