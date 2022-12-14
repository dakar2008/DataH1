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
                new ApplicationUser { UserName = "daniel@nesupport.dk", Email = "daniel@nesupport.dk", FirstName = "Daniel Vinther", LastName = "Andersen" },
                new ApplicationUser { UserName = "fros@techcollege.dk", Email = "fros@techcollege.dk", FirstName = "Frank", LastName = "Rosbak" },
                new ApplicationUser { UserName = "lkri@techcollege.dk", Email = "lkri@techcollege.dk", FirstName = "Lærke Brandhøj", LastName = "Kristensen" },
                new ApplicationUser { UserName = "ltpe@techcollege.dk", Email = "ltpe@techcollege.dk", FirstName = "Lars Thise", LastName = "Pedersen" },
                new ApplicationUser { UserName = "sinb@techcollege.dk", Email = "sinb@techcollege.dk", FirstName = "Simon Hoxer", LastName = "Bønding" }
            };

            foreach (var user in users)
            {
                var userStore = new UserStore<ApplicationUser>(_db);
                if (!_db.Users.Any(u => u.Email == user.Email))
                {
                    user.NormalizedEmail = user.Email.ToUpper();
                    user.NormalizedUserName = user.UserName.ToUpper();
                    user.NormalizedFirstName = user.FirstName.ToUpper();
                    user.NormalizedLastName = user.LastName.ToUpper();
                    
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