using System;

namespace GenSci.FamilyBudget.DataContext.Models
{
    /// <summary>
    /// Exchange rate history entity.
    /// </summary>
    public class ExchangeRateHistory
    {
        /// <summary>
        /// Exchange rate history identifier.
        /// </summary>
        public int ExchangeRateHistoryId { get; set; }

        /// <summary>
        /// Currency entity identifier.
        /// </summary>
        public int CurrencyId { get; set; }

        /// <summary>
        /// Exchange rate value.
        /// </summary>
        public double RateValue { get; set; }

        /// <summary>
        /// Date of adding exchange rate.
        /// </summary>
        public DateTime AddingDate { get; set; }


        /// <summary>
        /// Currency entity.
        /// </summary>
        public Currency Currency { get; set; }
    }
}
