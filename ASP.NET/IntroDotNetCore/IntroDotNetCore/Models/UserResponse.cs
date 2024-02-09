using System.ComponentModel.DataAnnotations;

namespace IntroDotNetCore.Models
{
    public class UserResponse
    {
        [Required(ErrorMessage = "Lütfen adınızı giriniz")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Lütfen Epostanızı giriniz")]

        public string Email { get; set; }
        [Required(ErrorMessage = "Lütfen seçiminizi yapın")]

        public bool IsParticipate { get; set; }

    }
}
