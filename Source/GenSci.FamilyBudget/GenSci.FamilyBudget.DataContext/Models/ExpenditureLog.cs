using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GenSci.FamilyBudget.DataContext.Models
{
    /// <summary>
    /// Money expenditure log entity.
    /// </summary>
    public class ExpenditureLog : BudgetLog
    {
        /// <summary>
        /// Expenditure place entity identifier.
        /// </summary>
        public int ExpenditurePlaceId { get; set; }

        /// <summary>
        /// Saved money value entity identifier.
        /// </summary>
        public int SavedValueId { get; set; }

        /// <summary>
        /// Expenditure note.
        /// </summary>
        public string Note { get; set; }
    }
}
