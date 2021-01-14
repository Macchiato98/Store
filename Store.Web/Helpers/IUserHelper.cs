﻿using Microsoft.AspNetCore.Identity;
using Store.Web.Data.Entidades;
using System.Threading.Tasks;

namespace Store.Web.Helpers
{
    public interface IUserHelper
    {
        Task<User> GetUserByEmailAsync(string email);

        Task<IdentityResult> AddUserAsync(User user, string password);
    }
}
