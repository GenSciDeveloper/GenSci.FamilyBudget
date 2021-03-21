﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GenSci.FamilyBudget.DataContext.Models
{
    /// <summary>
    /// User entity.
    /// </summary>
    public class User
    {
        /// <summary>
        /// User identifier.
        /// </summary>
        [Key]
        public int UserId { get; set; }

        /// <summary>
        /// User first name.
        /// </summary>
        [MaxLength(100)]
        public string FirstName { get; set; }

        /// <summary>
        /// User second name.
        /// </summary>
        [MaxLength(100)]
        public string SecondName { get; set; }

        /// <summary>
        /// Password hash.
        /// </summary>
        public byte[] PassHash { get; set; }

        /// <summary>
        /// Password salt.
        /// </summary>
        public byte[] PassSalt { get; set; }
    }
}
