﻿using Microsoft.AspNetCore.Identity;

public class ApplicationUser : IdentityUser
{
    public string FirstName { get; set; }
    public string MiddleName { get; set; }
    public string LastName { get; set; }
    public string PhoneNumber { get; set; }
}
