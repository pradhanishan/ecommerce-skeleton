using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Models.DTOS.User
{
    public sealed class GetRegisterUserDTO
    {
        [Required]
        public int Id { get; set; }

        [Required]
        [MinLength(2), MaxLength(40)]
        public string Username { get; set; } = String.Empty;

        [Required]
        [EmailAddress]
        public string EmailAddress { get; set; } = String.Empty;
    }
}
