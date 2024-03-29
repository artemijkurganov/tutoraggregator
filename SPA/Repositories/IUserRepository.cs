﻿namespace SPA.Repositories;

using Domain;
using EFCore.Postgres.Identity.Models;

#nullable enable

public interface IUserRepository
{
    Task<User?> GetAsync(Guid id);
    Task<User?> UpdateAsync(ApplicationUser user);
}