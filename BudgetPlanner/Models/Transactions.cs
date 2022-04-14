using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BudgetPlanner.Models
{
  public class Transactions
  {
    [Key]
    public int ID { get; set; }

    public decimal Amount { get; set; }

    [ForeignKey("Accounts")]
    public int AccountID { get; set; }

    [ForeignKey("Goals")]
    public int GoalID { get; set; }

    [ForeignKey("Category")]
    public int CategoryID { get; set; }

    [ForeignKey("Users")]
    public int UserID { get; set; }
  }
}
