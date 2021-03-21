using System.Collections.Generic;

namespace GenSci.FamilyBudget.DataContext.Models
{
    public class Currency
    {
        public int CurrencyId { get; set; }
        public int Caption { get; set; }
        public int Country { get; set; }
        public int CurrencySymbol { get; set; }

        public List<MoneyValue> MoneyValues { get; set; }
        public List<MonthlyLimit> MonthlyLimits { get; set; }
    }
}