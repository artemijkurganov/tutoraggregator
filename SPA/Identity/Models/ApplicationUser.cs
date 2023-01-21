﻿using Microsoft.AspNetCore.Identity;

namespace SPA.Identity.Models;

using V1.DataModels;

#nullable enable

public class ApplicationUser : IdentityUser<Guid>
{
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public string? Phone { get; set; }
    public Uri? Avatar { get; set; }
    public AccountType? AccountType { get; set; }
    public bool RegistrationCompleted { get; set; }
}