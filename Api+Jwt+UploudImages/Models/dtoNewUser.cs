﻿using System.ComponentModel.DataAnnotations;

namespace Api_Jwt_UploudImages.Models
{
    public class dtoNewUser
    {
        [Required]
        public string userName { get; set; }

        [Required]
        public string password { get; set; }

        [Required]
        public string email { get; set; }

        public string? phoneNumber { get; set; }
    }
}
