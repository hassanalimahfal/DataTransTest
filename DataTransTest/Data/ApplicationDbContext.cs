using DataTransTest.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DataTransTest.Data
{
    public class ApplicationDbContext : IdentityDbContext<AppUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Post> Posts { get; set; } = default!;
        public DbSet<Comment> Comments { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
            // Seed roles
            modelBuilder.Entity<IdentityRole>().HasData(
                new IdentityRole { Id = "1", Name = "Admin", NormalizedName = "ADMIN" },
                new IdentityRole { Id = "2", Name = "User", NormalizedName = "USER" }               
            );

            // Seed users
            var admin = new AppUser
            {
                Id = "1",
                FullName = "Admin",
                UserName = "admin@example.com",
                NormalizedUserName = "ADMIN@EXAMPLE.COM",
                Email = "admin@example.com",
                NormalizedEmail = "ADMIN@EXAMPLE.COM",
                EmailConfirmed = true
            };
            var adminPasswordHasher = new PasswordHasher<AppUser>();
            admin.PasswordHash = adminPasswordHasher.HashPassword(admin, "Admin123#");
            modelBuilder.Entity<AppUser>().HasData(admin);

            var user = new AppUser
            {
                Id = "2",
                FullName = "User",
                UserName = "user@example.com",
                NormalizedUserName = "USER@EXAMPLE.COM",
                Email = "user@example.com",
                NormalizedEmail = "USER@EXAMPLE.COM",
                EmailConfirmed = true
            };
            var userPasswordHasher = new PasswordHasher<AppUser>();
            user.PasswordHash = userPasswordHasher.HashPassword(user, "User123#");
            modelBuilder.Entity<AppUser>().HasData(user);

            // Assign the "Admin" role to the admin
            modelBuilder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string> { UserId = admin.Id, RoleId = "1" }
            );

            // Assign the "User" role to the user
            modelBuilder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string> { UserId = user.Id, RoleId = "2" }
            );


           /* modelBuilder.Entity<Post>()
                .HasData(new Post[]
                {
                    new Post { Id = 1, Title = "Sport", Body = "sssssss", AppUserId = "" },
                    new Post { Id = 2, Title = "Yemen", Body = "yyyyyyy", AppUserId = "" }

                });
            modelBuilder.Entity<Comment>()
               .HasData(new Comment[]
               {
                    new Comment { Id = 1, Content = "ccccccc", PostId = 1,  AppUserId = "" },
                    new Comment { Id = 2, Content = "ccccccc", PostId = 2,  AppUserId = "" }

               });*/


            /*modelBuilder.Entity<Post>()
                .HasOne(e => e.AppUser)
                .WithMany(e => e.Posts)
                .HasForeignKey(e => e.AppUserId)
                .IsRequired(false)
                .OnDelete(DeleteBehavior.NoAction);*/

            modelBuilder.Entity<Comment>()
                .HasOne(e => e.AppUser)
                .WithMany(e => e.Comments)
                .HasForeignKey(e => e.AppUserId)
                .IsRequired(false)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Comment>()
               .HasOne(e => e.Post)
               .WithMany(e => e.Comments)
               .HasForeignKey(e => e.PostId)
               .IsRequired(false)
               .OnDelete(DeleteBehavior.Cascade);


            base.OnModelCreating(modelBuilder);
        }
    }
}