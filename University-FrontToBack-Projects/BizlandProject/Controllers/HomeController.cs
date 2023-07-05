using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using BizlandProject.Models;

namespace BizlandProject.Controllers;

public class HomeController : Controller
{

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult InnerPage()
    {
        return View();
    }

    public IActionResult PortfolioDetails()
    {
        return View();
    }

}

