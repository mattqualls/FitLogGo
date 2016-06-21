using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using FitLogGo.Models;

namespace FitLogGo.Migrations
{
    [DbContext(typeof(FitLogGoDbContext))]
    [Migration("20160620212912_MyFirstMigration")]
    partial class MyFirstMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.0.0-rc2-20901")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("FitLogGo.Models.AppUser", b =>
                {
                    b.Property<int>("AppUserId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Age");

                    b.Property<string>("Email");

                    b.Property<int>("InitialWeight");

                    b.Property<DateTime>("JoinDate");

                    b.Property<string>("Username")
                        .HasAnnotation("MaxLength", 20);

                    b.HasKey("AppUserId");

                    b.ToTable("AppUsers");
                });

            modelBuilder.Entity("FitLogGo.Models.Session", b =>
                {
                    b.Property<int>("SessionId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AppUserId");

                    b.Property<int>("CaloriesBurned");

                    b.Property<double>("MilesTraveled");

                    b.Property<double>("MinutesWorked");

                    b.Property<DateTime>("SessionDate");

                    b.Property<int>("SessionWeight");

                    b.HasKey("SessionId");

                    b.HasIndex("AppUserId");

                    b.ToTable("Sessions");
                });

            modelBuilder.Entity("FitLogGo.Models.SessionType", b =>
                {
                    b.Property<int>("SessionTypeId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("BikeId");

                    b.Property<int>("EllipticalId");

                    b.Property<int>("SessionId");

                    b.Property<int>("TreadmillId");

                    b.HasKey("SessionTypeId");

                    b.HasIndex("SessionId");

                    b.ToTable("SessionTypes");
                });

            modelBuilder.Entity("FitLogGo.Models.Session", b =>
                {
                    b.HasOne("FitLogGo.Models.AppUser")
                        .WithMany()
                        .HasForeignKey("AppUserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("FitLogGo.Models.SessionType", b =>
                {
                    b.HasOne("FitLogGo.Models.Session")
                        .WithMany()
                        .HasForeignKey("SessionId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
        }
    }
}
