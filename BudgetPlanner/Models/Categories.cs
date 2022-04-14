using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BudgetPlanner.Models
{
  public class Categories
  {
    [Key]
    public int ID { get; set; }

    public string Category { get; set; }
  }
}
