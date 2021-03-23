using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GenSci.FamilyBudget.DataContext.Models
{
    /// <summary>
    /// Currency entity.
    /// </summary>
    public class Currency
    {
        /// <summary>
        /// Currency entity identifier.
        /// </summary>
        [Key]
        public int CurrencyId { get; set; }

        /// <summary>
        /// Caprion if currency.
        /// </summary>
        [Required]
        public string Caption { get; set; }

        /// <summary>
        /// The main location of currency using.
        /// </summary>
        public string Location { get; set; }

        /// <summary>
        /// Currency symbol.
        /// </summary>
        public int CurrencySymbol { get; set; }

        /// <summary>
        /// Collection of money values.
        /// </summary>
        public List<MoneyValue> MoneyValues { get; set; }

        /// <summary>
        /// Collection of monthly limits.
        /// </summary>
        public List<MonthlyLimit> MonthlyLimits { get; set; }
    }
}