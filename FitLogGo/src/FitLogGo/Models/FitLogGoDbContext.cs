using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace FitLogGo.Models
{
    public class FitLogGoDbContext : DbContext
    {
        public FitLogGoDbContext()
        {
        }

        public FitLogGoDbContext(DbContextOptions<FitLogGoDbContext> options)
      : base(options)
    { }

        public DbSet<AppUser> AppUsers { get; set; }
        public DbSet<Session> Sessions { get; set; }
        public DbSet<SessionType> SessionTypes { get; set; }

        //protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<AppUser>()
        //        .ToTable("AppUser")
        //        .HasKey(c => c.AppUserId);

        //    modelBuilder.Entity<Session>()
        //        .ToTable("Session")
        //        .HasKey(c => c.SessionId);

        //    modelBuilder.Entity<SessionType>()
        //        .ToTable("IndividualPiece")
        //        .HasKey(c => c.SessionTypeId);

        //}
    }
}
