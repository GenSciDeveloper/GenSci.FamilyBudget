namespace GenSci.FamilyBudget.DataContext.Models
{
    /// <summary>
    /// Money income Log entity.
    /// </summary>
    public class IncomeLog : BudgetLog
    {
        /// <summary>
        /// Income type entity identifier.
        /// </summary>
        public int IncomeTypeId { get; set; }

        /// <summary>
        /// Income type entity.
        /// </summary>
        public IncomeType IncomeType { get; set; }
    }
}
