using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Models.Entities
{
    public sealed class UserRole
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public Guid UserId { get; set; }

        [Required]
        [ForeignKey("UserId")]
        public User? User { get; set; }

        [Required]
        public int RoleId { get; set; }

        [Required]
        [ForeignKey("RoleId")]
        public Role? Role { get; set; }



    }
}
