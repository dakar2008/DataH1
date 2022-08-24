using Microsoft.AspNetCore.Identity;

namespace ScheduleAnalyzer.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string NormalizedFirstName { get; set; }
        public string LastName { get; set; }
        public string NormalizedLastName { get; set; }
        public bool UserMustChangePassword { get; set; }

        public ApplicationUser()
        {
            UserMustChangePassword = true;
        }
    }
}