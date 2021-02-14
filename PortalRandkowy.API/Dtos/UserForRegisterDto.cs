using System.ComponentModel.DataAnnotations;

namespace PortalRandkowy.API.Dtos
{
    public class UserForRegisterDto
    {
        [Required(ErrorMessage="Username is required")]
        public string Username { get; set; }
        [Required(ErrorMessage="Password is required")]
        [StringLength(12,MinimumLength=6,ErrorMessage="Password must contains from 6 to 12 signs")]
        public string Password { get; set; }
                
    }
}