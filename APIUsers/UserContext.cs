using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIUsers
{
    public class UserContext: DbContext
    {
        public UserContext(DbContextOptions<UserContext> options):base(options)
        {

        }

        public DbSet<Models.User> Users { get; set; }

    }
}
