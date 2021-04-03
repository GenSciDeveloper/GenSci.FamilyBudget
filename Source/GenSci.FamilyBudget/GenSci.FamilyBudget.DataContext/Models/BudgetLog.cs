using System.ComponentModel.DataAnnotations;

namespace GenSci.FamilyBudget.DataContext.Models
{
    /// <summary>
    /// Base class for IncomeLog and ExpenditureLog classes
    /// </summary>
    public class BudgetLog
    {
        /// <summary>
        /// Income log identifier.
        /// </summary>
        [Key]
        public int BudgetLogId { get; set; }

        /// <summary>
        /// Money value entity identifier.
        /// </summary>
        public int MoneyValueId { get; set; }

        /// <summary>
        /// User entity identifier.
        /// </summary>
        public int UserId { get; set; }

        /// <summary>
        /// User entity.
        /// </summary>
        public User User { get; set; }

        /// <summary>
        /// Money value entity.
        /// </summary>
        public MoneyValue MoneyValue { get; set; }
    }
}
