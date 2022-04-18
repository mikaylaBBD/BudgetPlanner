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
      return View();
    }

    [HttpPost]
    public IActionResult Index(Transactions transactions)
    {

      //if (string.IsNullOrEmpty(transactions.ID.ToString()))
      //{
      //  return View();
      //}

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
