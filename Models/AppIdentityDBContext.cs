﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Intex_Semester_2.Models
{
    public class AppIdentityDBContext : IdentityDbContext<IdentityUser>
    {
        public AppIdentityDBContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Identity> Identity { get; set; }
    }
}
