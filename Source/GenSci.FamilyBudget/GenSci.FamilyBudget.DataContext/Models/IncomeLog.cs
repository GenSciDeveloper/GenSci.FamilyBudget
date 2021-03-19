using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GenSci.FamilyBudget.DataContext.Models
{
    /// <summary>
    /// Money income Log entity.
    /// </summary>
    [Table("IncomeLogs")]
    public class IncomeLog
    {
        /// <summary>
        /// Income log identifier.
        /// </summary>
        [Key]
        public int IncomeLogId { get; set; }

        /// <summary>
        /// Income type entity identifier.
        /// </summary>
        public int IncomeTypeId { get; set; }

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
