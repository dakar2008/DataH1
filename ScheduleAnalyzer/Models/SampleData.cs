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
                new ApplicationUser { UserName = "daniel@nesupport.dk", Email = "daniel@nesupport.dk", NormalizedUserName = "daniel@nesupport.dk".ToUpper(), NormalizedEmail = "daniel@nesupport.dk".ToUpper(), FirstName = "Daniel Vinther", NormalizedFirstName = "Daniel Vinther".ToUpper(), LastName = "Andersen", NormalizedLastName = "Andersen".ToUpper() },
                new ApplicationUser { UserName = "fros@techcollege.dk", Email = "fros@techcollege.dk", NormalizedUserName = "fros@techcollege.dk".ToUpper(), NormalizedEmail = "fros@techcollege.dk".ToUpper(), FirstName = "Frank", NormalizedFirstName = "Frank".ToUpper(), LastName = "Rosbak", NormalizedLastName = "Rosbak".ToUpper()},
                new ApplicationUser { UserName = "lkri@techcollege.dk", Email = "lkri@techcollege.dk",NormalizedUserName = "lkri@techcollege.dk".ToUpper(), NormalizedEmail = "lkri@techcollege.dk".ToUpper(), FirstName = "Lærke Brandhøj", NormalizedFirstName = "Lærke Brandhøj".ToUpper(), LastName = "Kristensen", NormalizedLastName = "Kristensen".ToUpper()},
                new ApplicationUser { UserName = "ltpe@techcollege.dk", Email = "ltpe@techcollege.dk",NormalizedUserName = "ltpe@techcollege.dk".ToUpper(), NormalizedEmail = "ltpe@techcollege.dk".ToUpper(), FirstName = "Lars Thise", NormalizedFirstName = "Lars Thise".ToUpper(), LastName = "Pedersen", NormalizedLastName = "Pedersen".ToUpper()},
                new ApplicationUser { UserName = "sinb@techcollege.dk", Email = "sinb@techcollege.dk", NormalizedUserName = "sinb@techcollege.dk".ToUpper(), NormalizedEmail = "sinb@techcollege.dk".ToUpper(), FirstName = "Simon Hoxer", NormalizedFirstName = "Simon Hoxer".ToUpper(), LastName = "Bønding", NormalizedLastName = "Bønding".ToUpper()}
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