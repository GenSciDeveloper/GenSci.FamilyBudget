using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GenSci.FamilyBudget.DataContext.Models
{
    /// <summary>
    /// Money value entity.
    /// </summary>
    public class MoneyValue
    {
        /// <summary>
        /// Money value identifier.
        /// </summary>
        [Key]
        public int MoneyValueId { get; set; }

        /// <summary>
        /// Currency entity identifier.
        /// </summary>
        public int CurrencyId { get; set; }

        /// <summary>
        /// The amount of money in the currency specified in <see cref="CurrencyId"/>.
        /// </summary>
        [Required]
        public double Value { get; set; }

        /// <summary>
        /// Date of adding money income or expenses.
        /// </summary>
        [Required]
        public DateTime AddingDate { get; set; }

        /// <summary>
        /// Collection of expenditure logs.
        /// </summary>
        public List<ExpenditureLog> ExpenditureLogs { get; set; }

        /// <summary>
        /// Collection of income logs.
        /// </summary>
        public List<IncomeLog> IncomeLogs { get; set; }
    }
}
