using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using StartBootstrapProject.Models;

namespace StartBootstrapProject.Controllers;

public class HomeController : Controller
{
   

    public IActionResult Index()
    {
        return View();
    }

    
}

