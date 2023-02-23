using System.ComponentModel.DataAnnotations;

namespace Api_Jwt_UploudImages.Models
{
    public class dtoLogin
    {
        [Required]
        public string userName { get; set; }

        [Required]
        public string password { get; set; }
    }
}
