﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Models.Entities
{
    public sealed class Role
    {
        [Required]
        [Key]
        public int Id { get; set; }

        [Required]
        [MinLength(4), MaxLength(10)]
        public string Name { get; set; } = String.Empty;

        [Required]

        public DateTimeOffset CreatedDate = DateTimeOffset.UtcNow;

        [Required]

        public DateTimeOffset UpdatedDate = DateTimeOffset.UtcNow;



    }
}
