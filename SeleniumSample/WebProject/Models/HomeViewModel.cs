using System.ComponentModel.DataAnnotations;

namespace WebProject.Models
{
    public class HomeViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
    }
}