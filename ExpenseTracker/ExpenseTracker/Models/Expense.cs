using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExpenseTracker.Models
{
    public class Expense
    {
        public string Name { get; set; }
        public double Value { get; set; }
        public DueDateInformation DueDateInfo { get; set; }
    }

    public class DueDateInformation
    {
        public DateTime DueDate { get; set; }
        public double Penalty { get; set; }
    }
}