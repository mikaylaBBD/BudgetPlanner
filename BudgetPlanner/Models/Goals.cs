using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BudgetPlanner.Models
{
  public class Goals
  {
    [Key]
    public int ID { get; set; }

    public string Goal { get; set; }
  }
}
