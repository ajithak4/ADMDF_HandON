using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AccountDetails.Models;

namespace AccountDetails.Data
{
    public class AccountDetailsContext : DbContext
    {
        public AccountDetailsContext (DbContextOptions<AccountDetailsContext> options)
            : base(options)
        {
        }

        public DbSet<AccountDetails.Models.Account> Account { get; set; }
    }
}
