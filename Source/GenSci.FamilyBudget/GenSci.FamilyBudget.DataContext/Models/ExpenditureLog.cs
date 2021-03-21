using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GenSci.FamilyBudget.DataContext.Models
{
    /// <summary>
    /// Money expenditure log entity.
    /// </summary>
    public class ExpenditureLog
    {
        /// <summary>
        /// Expenditure log identifier.
        /// </summary>
        [Key]
        public int ExpenditureLogId { get; set; }

        /// <summary>
        /// Expenditure place entity identifier.
        /// </summary>
        public int ExpenditurePlaceId { get; set; }

        /// <summary>
        /// Money value entity identifier.
        /// </summary>
        public int MoneyValueId { get; set; }

        /// <summary>
        /// User entity identifier.
        /// </summary>
        public int UserId { get; set; }
    }
}
