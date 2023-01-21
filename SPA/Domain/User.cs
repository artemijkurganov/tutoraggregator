﻿namespace SPA.Domain;

using Identity.Models;

public sealed record User(string FirstName, string LastName, Uri Avatar, AccountType? AccountType, bool RegistrationCompleted);