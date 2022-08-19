using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using ScheduleAnalyzer.Data;

namespace ScheduleAnalyzer.Models
{
    public class SampleData
    {
        private ApplicationDbContext _db;

        public SampleData(ApplicationDbContext db)
        {
            _db = db;
        }
        
        public async void Initialize()
        {
            string[] roles = {
                "Admin"
            };
            foreach (var role in roles)
            {
                var roleStore = new RoleStore<IdentityRole>(_db);
                if (!_db.Roles.Any(r => r.Name == role))
                {
                    IdentityRole newrole = new IdentityRole();
                    newrole.Name = role;
                    newrole.NormalizedName = role;
                    await roleStore.CreateAsync(newrole);
                }
            }

            ApplicationUser[] users =
            {
                //TODO: Remove First Record From ApplicationUser List Before Release
                new ApplicationUser { UserName = "daniel@nesupport.dk", NormalizedUserName = "daniel@nesupport.dk", Email = "daniel@nesupport.dk", NormalizedEmail = "daniel@nesupport.dk", FirstName = "Daniel Vinther", LastName = "Andersen", EmailConfirmed = true },
                new ApplicationUser { UserName = "fros@techcollege.dk", Email = "fros@techcollege.dk", NormalizedUserName = "fros@techcollege.dk", NormalizedEmail = "fros@techcollege.dk", FirstName = "Frank", LastName = "Rosbak", EmailConfirmed = true },
                new ApplicationUser { UserName = "lkri@techcollege.dk", Email = "lkri@techcollege.dk",NormalizedUserName = "lkri@techcollege.dk", NormalizedEmail = "lkri@techcollege.dk", FirstName = "Lærke Brandhøj", LastName = "Kristensen", EmailConfirmed = true },
                new ApplicationUser { UserName = "ltpe@techcollege.dk", Email = "ltpe@techcollege.dk",NormalizedUserName = "ltpe@techcollege.dk", NormalizedEmail = "ltpe@techcollege.dk", FirstName = "Lars Thise", LastName = "Pedersen", EmailConfirmed = true },
                new ApplicationUser { UserName = "sinb@techcollege.dk", Email = "sinb@techcollege.dk", NormalizedUserName = "sinb@techcollege.dk", NormalizedEmail = "sinb@techcollege.dk", FirstName = "Simon Hoxer", LastName = "Bønding", EmailConfirmed = true }
            };

            foreach (var user in users)
            {
                var userStore = new UserStore<ApplicationUser>(_db);
                if (!_db.Users.Any(u => u.Email == user.Email))
                {
                    var password = new PasswordHasher<ApplicationUser>();
                    var hashed = password.HashPassword(user, "Password1234*");
                    user.PasswordHash = hashed;

                    await userStore.CreateAsync(user);
                    await userStore.AddToRoleAsync(user, "Admin");
                }
                await _db.SaveChangesAsync();
            }
        }
    }
}