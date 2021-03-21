using GenSci.FamilyBudget.DataContext.Enums;

namespace GenSci.FamilyBudget.DataContext.Models
{
    /// <summary>
    /// Monthly limit entity.
    /// </summary>
    public class MonthlyLimit
    {
        /// <summary>
        /// Monthly limit identifier.
        /// </summary>
        public int MonthlyLimitId { get; set; }

        /// <summary>
        /// Expenditure category entity identifier.
        /// </summary>
        public int ExpenditureCategoryId { get; set; }

        /// <summary>
        /// Value of money limit.
        /// </summary>
        public int Value { get; set; }

        /// <summary>
        /// Value limit type.
        /// </summary>
        public eLimitType LimitType { get; set; }

        /// <summary>
        /// Currency entity identifier.
        /// </summary>
        public int CurrencyId { get; set; }

        /// <summary>
        /// Expenditure category entity.
        /// </summary>
        public ExpenditureCategory ExpenditureCategory { get; set; }

        /// <summary>
        /// Currency entity.
        /// </summary>
        public Currency Currency { get; set; }
    }
}