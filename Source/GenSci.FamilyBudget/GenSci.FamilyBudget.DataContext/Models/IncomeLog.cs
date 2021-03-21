﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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
    }
}
