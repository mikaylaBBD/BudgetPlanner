using BudgetPlanner.Database;
using BudgetPlanner.Models;
using Microsoft.AspNetCore.Mvc;
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


      List<Transactions> AllTransactions = new List<Transactions>();

      foreach (Transactions transactions1 in _dBManager.Transactions)
      {
        AllTransactions.Add(transactions1);
      }

      List<string> users = new List<string>();

      foreach(Users user in _dBManager.Users)
      {
        users.Add(user.UserName);
      }

      ViewBag.Users = users; //For Dropdown
      ViewBag.BobTransactions = AllTransactions.Where(x => x.Token == 1);
      ViewBag.ChrisTransactions = AllTransactions.Where(x => x.Token == 2);
      ViewBag.JamesTransactions = AllTransactions.Where(x => x.Token == 3);



      return View();
    }

    [HttpPost]
    public IActionResult Index(Transactions transactions)
    {

      return View();
    }


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
