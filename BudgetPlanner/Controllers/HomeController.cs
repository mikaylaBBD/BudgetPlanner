using BudgetPlanner.Database;
using BudgetPlanner.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace BudgetPlanner.Controllers
{
  public class HomeController : Controller
  {
    private readonly DBManager _dBManager;
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger, DBManager dBManager)
    {
      _dBManager = dBManager;
      _logger = logger;
    }

    public IActionResult Index()
    {
      Console.WriteLine(_dBManager.Transactions.Find(1).TransactionAmount.ToString());

      ViewBag.Users = new SelectList(_dBManager.Users, nameof(Users.Token).ToString(), nameof(Users.UserName)); ; //For Dropdown

      return View();
    }

    //[HttpPost]
    //public IActionResult Index(Users user)
    //{
    //  user.UserName = "James";
    //  if(string.IsNullOrEmpty(user.UserName))
    //  {
    //    return View();
    //  }
    //  string name = user.UserName;

    //  List<Users> users = new List<Users>();

    //  foreach (Users user1 in _dBManager.Users)
    //  {
    //    users.Add(user1);
    //  }

    //  int user2 = users.FindIndex(x => x.UserName == name);

    //  Console.WriteLine(user2);

    //  List<Transactions> AllTransactions = new List<Transactions>();

    //  foreach (Transactions transactions1 in _dBManager.Transactions)
    //  {
    //    AllTransactions.Add(transactions1);
    //  }

    //  ViewBag.Users = new SelectList(_dBManager.Users, nameof(Users.Token), nameof(Users.UserName)); ; //For Dropdown
    //  ViewBag.UserTransactions = AllTransactions.Where(x => x.Token == 1).ToList();



    //  return View();
    //}


    public IActionResult Privacy()
    {
      return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
      return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
  }
}
