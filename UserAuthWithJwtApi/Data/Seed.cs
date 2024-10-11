using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace UserAuthWithJwtApi.Data
{
    internal class Seed
    {
        public const string ADMIN_ROLE_ID = "d4e8321b-447b-43d2-bdce-f4738b588bec";
        public const string ADMIN_ROLE = "Admin";
        public const string USER_ROLE_ID = "eb6b2a41-9e08-4243-bf9b-74f5ac6d9297";
        public const string USER_ROLE = "User";

        public const string ROOT_USER_ID = "3a32e868-9191-4c77-a8ea-4c825571b5bf";
        public const string ROOT_USER_NAME = "R. Root";
        public const string ROOT_USER_EMAIL = "root@example.com";

        public const string JOHN_USER_ID = "4b43c757-9e01-4243-bf9b-f4738b588bec";
        public const string JOHN_USER_NAME = "John Doe";
        public const string JOHN_USER_EMAIL = "john.doe@example.com";

        public const string DEFAULT_PWD_HASH = "AQAAAAIAAYagAAAAEI9bnzxidZZ+yhCWxSEb3S6FK1cSyK/2GPjRLnssQErapeLrjxRDdlzL22WyyowLRA=="; // Syst3m

        internal readonly static Seed Instance = new();

        public List<IdentityRole> Roles => 
        [
            new IdentityRole 
            {
                Id = ADMIN_ROLE_ID,
                Name = ADMIN_ROLE,
                NormalizedName = ADMIN_ROLE.ToUpper()
            },
            new IdentityRole 
            {
                Id = USER_ROLE_ID,
                Name = USER_ROLE,
                NormalizedName = USER_ROLE.ToUpper()
            },
        ];

        public List<IdentityUser> Users => 
        [
            new IdentityUser 
            {
                Id = ROOT_USER_ID,
                UserName = ROOT_USER_NAME,
                NormalizedUserName = ROOT_USER_NAME.ToUpper(),
                Email = ROOT_USER_EMAIL,
                NormalizedEmail = ROOT_USER_EMAIL.ToUpper(),
                PasswordHash = DEFAULT_PWD_HASH
            },
            new IdentityUser 
            {
                Id = JOHN_USER_ID,
                UserName = JOHN_USER_NAME,
                NormalizedUserName = JOHN_USER_NAME.ToUpper(),
                Email = JOHN_USER_EMAIL,
                NormalizedEmail = JOHN_USER_EMAIL.ToUpper(),
                PasswordHash = DEFAULT_PWD_HASH
            }
        ];

        public List<IdentityUserRole<string>> UsersRoles => 
        [
            new IdentityUserRole<string> 
            {
                RoleId = ADMIN_ROLE_ID,
                UserId = ROOT_USER_ID
            },
            new IdentityUserRole<string>
            {
                RoleId = USER_ROLE_ID,
                UserId = JOHN_USER_ID
            }
        ];

        private Seed()
        {
        }

        internal void SeedData(ModelBuilder builder)
        {
            builder.Entity<IdentityRole>().HasData(Roles);
            builder.Entity<IdentityUser>().HasData(Users);
            builder.Entity<IdentityUserRole<string>>().HasData(UsersRoles);
        }
    }
}
