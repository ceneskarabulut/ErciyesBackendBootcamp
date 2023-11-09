using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using BootcampCografyaProje.Models;
using NuGet.Protocol.Core.Types;

namespace BootcampCografyaProje.Controllers;

public class HomeController : Controller
{
  
    public IActionResult Index()
    {
        return View(Main.Cografyas);
    }

    
        public IActionResult About()
        {
            return View();
        }
    }


