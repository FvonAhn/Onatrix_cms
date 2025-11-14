using System.ComponentModel.DataAnnotations;

namespace Onatrix_cms.ViewModels
{
    public class CallbackFormViewModel
    {
        [Required(ErrorMessage = "Name is required")]
        [Display(Name = "Name")]
        public string Name { get; set; } = null!;

        [Required(ErrorMessage = "Email is required")]
        [Display(Name = "Email adress")]
        [RegularExpression(@"^[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,}$", ErrorMessage = "You need to enter a valid email adress.")]
        public string Email { get; set; } = null!;

        [Required(ErrorMessage = "Phone number is required")]
        [Display(Name = "Phone")]
        public string Phone { get; set; } = null!;

        [Required(ErrorMessage = "An option is required")]
        public string SelectedOption { get; set; } = null!;
    }
}
