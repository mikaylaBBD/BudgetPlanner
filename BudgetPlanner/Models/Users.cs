﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BudgetPlanner.Models
{
  public class Users
  {
    [Key]
    public int UserID { get; set; }

    public string UserName { get; set; }

    public string Token { get; set; }
    }
}
