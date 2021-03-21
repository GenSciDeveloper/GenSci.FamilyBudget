using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GenSci.FamilyBudget.DataContext.Models
{
    /// <summary>
    /// Expenditure category entity.
    /// </summary>
    public class ExpenditureCategory
    {
        /// <summary>
        /// Expenditure category identifier.
        /// </summary>
        [Key]
        public int ExpenditureCategoryId { get; set; }

        /// <summary>
        /// Caption of expenditure category.
        /// </summary>
        public string Caption { get; set; }

        /// <summary>
        /// Collection of expenditure places.
        /// </summary>
        public List<ExpenditurePlace> ExpenditurePlaces { get; set; }

        /// <summary>
        /// Collection of monthly limits.
        /// </summary>
        public List<MonthlyLimit> MonthlyLimits { get; set; }
    }
}