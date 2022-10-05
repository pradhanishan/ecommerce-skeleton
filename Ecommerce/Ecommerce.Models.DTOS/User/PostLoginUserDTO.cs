using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Models.DTOS.User
{
    public sealed class PostLoginUserDTO
    {
        [Required]
        public string UsernameOrEmailAddress { get; set; } = string.Empty;

        [Required]
        public string Password { get; set; } = string.Empty;

    }
}
