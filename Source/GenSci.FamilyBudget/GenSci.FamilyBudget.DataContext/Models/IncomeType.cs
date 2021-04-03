using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GenSci.FamilyBudget.DataContext.Models
{
    /// <summary>
    /// Income type entity.
    /// </summary>
    public class IncomeType
    {
        /// <summary>
        /// Income type identifier.
        /// </summary>
        [Key]
        public int IncomeTypeId { get; set; }

        /// <summary>
        /// Income type caption
        /// </summary>
        [Required, MaxLength(50)]
        public string Caption { get; set; }

        /// <summary>
        /// Date of adding income type.
        /// </summary>
        public DateTime AddingDate { get; set; }

        /// <summary>
        /// Collection of income logs.
        /// </summary>
        public List<IncomeLog> IncomeLogs { get; set; }
    }
}