using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace FitLogGo.Models
{
    public class FitLogGoDbContext : DbContext
    {
        public FitLogGoDbContext(DbContextOptions<FitLogGoDbContext> options)
      : base(options)
    { }

        public DbSet<AppUser> AppUsers { get; set; }
        public DbSet<Session> Sessions { get; set; }
        public DbSet<SessionType> SessionTypes { get; set; }
    }
}
