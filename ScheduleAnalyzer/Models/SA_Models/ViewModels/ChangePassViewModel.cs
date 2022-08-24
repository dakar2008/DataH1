using System.ComponentModel.DataAnnotations;

namespace ScheduleAnalyzer.Models.SA_Models.ViewModels
{
    public class ChangePassViewModel
    {
        [Required(ErrorMessage = "Du skal indtaste den gamle adgangskode")]
        [DataType(DataType.Password)]
        [Display(Name = "Nuværende adgangskode")]
        public string OldPassword { get; set; }
        [Required(ErrorMessage = "Du skal indtaste en ny adgangskode")]
        [StringLength(100, ErrorMessage = "{0} skal minimum være {2} og maksimalt være {1} karaktere lang.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Ny adgangskode")]
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)[a-zA-Z\d]{6,}$", ErrorMessage = "Adgangskode skal indeholde mindst 1 tal, mindst 1 stort bogstav, mindst 1 lille bogstav")]
        public string NewPassword { get; set; }
        [DataType(DataType.Password)]
        [Display(Name = "Bekræft ny adgangskode")]
        [Compare("NewPassword", ErrorMessage = "Adgangskoden i bekræftigelsesfeltet matcher ikke med koden i Ny adgangskode")]
        public string ConfirmPassword { get; set; }
        public ApplicationUser User { get; set; }
    }
}