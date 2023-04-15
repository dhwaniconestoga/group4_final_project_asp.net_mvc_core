﻿using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;

namespace Group4_FinalProject.Models
{
    public class UserViewModel
    {
        public IEnumerable<User> Users { get; set; }
        public IEnumerable<IdentityRole> Roles { get; set; }
    }
}
