using System.ComponentModel.DataAnnotations;

namespace ScheduleAnalyzer.Models
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "You must enter a e-mail address")]
        [EmailAddress(ErrorMessage = "You must enter a valid e-mail address")]
        public string Email { get; set; }
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}