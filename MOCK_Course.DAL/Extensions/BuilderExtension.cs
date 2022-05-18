using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using MOCK_Course.DAL.Models;
using System;

namespace BlogDAL.Extension
{
    public static class BuilderExtension
    {
        public static void ConfigTablesOfIdentity(this ModelBuilder builder)
        {
            const string claims = "AppUserClaims";
            const string roles = "AppUserRoles";
            const string userLogins = "AppUserLogins";
            const string roleClaims = "AppRoleClaims";
            const string userTokens = "AppUserTokens";

            builder.Entity<IdentityUserClaim<Guid>>().ToTable(claims);
            builder.Entity<IdentityUserRole<Guid>>().ToTable(roles).HasKey(x => new { x.UserId, x.RoleId });
            builder.Entity<IdentityUserLogin<Guid>>().ToTable(userLogins).HasKey(x => x.UserId);
            builder.Entity<IdentityRoleClaim<Guid>>().ToTable(roleClaims);
            builder.Entity<IdentityUserToken<Guid>>().ToTable(userTokens).HasKey(x => x.UserId);
        }

        public static void SeedData(this ModelBuilder builder)
        {
            builder.Entity<IdentityRole<Guid>>().HasData(
                new IdentityRole<Guid> { Name = "Student", Id = Guid.NewGuid() },
                new IdentityRole<Guid> { Name = "Instructor", Id = Guid.NewGuid() });

            var roleId = Guid.NewGuid();
            var adminId = Guid.NewGuid();

            builder.Entity<IdentityRole<Guid>>().HasData(new IdentityRole<Guid>
            {
                Id = roleId,
                Name = "Admin",
            });

            var hasher = new PasswordHasher<AppUser>();
            builder.Entity<AppUser>().HasData(new AppUser
            {
                Id = adminId,
                Email = "admin123@gmail.com",
                EmailConfirmed = true,
                PasswordHash = hasher.HashPassword(null, "1"),
                SecurityStamp = string.Empty,
            });

            builder.Entity<IdentityUserRole<Guid>>().HasData(new IdentityUserRole<Guid>
            {
                RoleId = roleId,
                UserId = adminId
            });
        }
    }
}
