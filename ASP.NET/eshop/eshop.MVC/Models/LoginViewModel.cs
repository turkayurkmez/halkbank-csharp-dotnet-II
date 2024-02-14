using System.ComponentModel.DataAnnotations;

namespace eshop.MVC.Models
{
    public class LoginViewModel
    {
        [Required]
        public string UserName { get; set; }

        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
