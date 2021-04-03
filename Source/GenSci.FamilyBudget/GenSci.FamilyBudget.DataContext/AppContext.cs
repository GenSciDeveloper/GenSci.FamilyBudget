using GenSci.FamilyBudget.DataContext.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace GenSci.FamilyBudget.DataContext
{
    public class AppContext : DbContext
    {
        #region Entities sets
        public DbSet<User> Users { get; set; }

        public DbSet<BudgetLog> BudgetLogs { get; set; }

        public DbSet<CirculationScheduler> CirculationSchedulers { get; set; }

        public DbSet<Currency> Currencies { get; set; }

        public DbSet<ExchangeRateHistory> ExchangeRateHistories { get; set; }

        public DbSet<ExpenditureCategory> ExpenditureCategories { get; set; }

        public DbSet<ExpenditureLog> ExpenditureLogs { get; set; }

        public DbSet<ExpenditurePlace> ExpenditurePlaces { get; set; }

        public DbSet<IncomeLog> IncomeLogs { get; set; }

        public DbSet<IncomeType> IncomeTypes { get; set; }

        public DbSet<MoneyValue> MoneyValues { get; set; }

        public DbSet<MonthlyLimit> MonthlyLimits { get; set; } 
        #endregion
    }
}
