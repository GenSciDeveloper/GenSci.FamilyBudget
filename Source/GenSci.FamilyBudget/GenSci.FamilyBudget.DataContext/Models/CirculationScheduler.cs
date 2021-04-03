using GenSci.FamilyBudget.DataContext.Enums;
using System.ComponentModel.DataAnnotations;

namespace GenSci.FamilyBudget.DataContext.Models
{
    /// <summary>
    /// Circulation scheduler entity.
    /// </summary>
    public class CirculationScheduler
    {
        /// <summary>
        /// Circulation scheduler identifier.
        /// </summary>
        [Key]
        public int CirculationSchedulerId { get; set; }

        /// <summary>
        /// Circulation type.
        /// </summary>
        public eCirculationType CirculationType { get; set; }

        /// <summary>
        /// Circulation frequency.
        /// </summary>
        public eFrequency Frequency { get; set; }

        /// <summary>
        /// Currency entity identifier.
        /// </summary>
        public int CurrencyId { get; set; }

        /// <summary>
        /// Value of money.
        /// </summary>
        public double Value { get; set; }

        /// <summary>
        /// User entity identifier.
        /// </summary>
        public int UserId { get; set; }

        /// <summary>
        /// Currency entity.
        /// </summary>
        public Currency Currency { get; set; }

        /// <summary>
        /// User entity.
        /// </summary>
        public User User { get; set; }
    }
}
