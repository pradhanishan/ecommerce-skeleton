using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Models.Entities
{
    public sealed class User
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Required]
        [MinLength(2), MaxLength(40)]
        public string Username { get; set; } = String.Empty;

        [Required]
        [EmailAddress]
        public string EmailAddress { get; set; } = String.Empty;

        [Required]
        public byte[]? PasswordSalt { get; set; }

        [Required]
        public byte[]? PasswordHash { get; set; }

        [Required]
        public bool IsActive { get; set; } = true;

        [Required]
        public DateTimeOffset CreatedDate { get; set; } = DateTimeOffset.UtcNow;
        [Required]
        public DateTimeOffset UpdatedDate { get; set; } = DateTimeOffset.UtcNow;



    }
}
