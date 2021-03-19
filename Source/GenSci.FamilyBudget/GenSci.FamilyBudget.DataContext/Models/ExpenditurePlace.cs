﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GenSci.FamilyBudget.DataContext.Models
{
    /// <summary>
    /// Expenditure place entity.
    /// </summary>
    [Table("ExpenditurePlaces")]
    public class ExpenditurePlace
    {
        /// <summary>
        /// Expenditure place identifier.
        /// </summary>
        [Key]
        public int ExpenditurePlaceId { get; set; }

        /// <summary>
        /// Expenditure category entity identifier.
        /// </summary>
        public int ExpenditureCategoryId { get; set; }

        /// <summary>
        /// Caption of expenditure place.
        /// </summary>
        [Required, MaxLength(50)]
        public string Caption { get; set; }

        /// <summary>
        /// Date of adding expenditure place.
        /// </summary>
        [Required]
        public DateTime AddingDate { get; set; }
    }
}
