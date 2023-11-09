using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BootcampCografyaProje.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BootcampCografyaProje.Controllers
{
    public class CografyaController : Controller
    {
        public IActionResult Kuvvet(int? id)
        {
            if (id == null && id>0)
            {
                return Redirect("/cografya/kuvvet");
            }
            var kuvvet = Main.GetById(id);
            return View(kuvvet);
        }

        public IActionResult Details(int? id)
        {
            if (id == null && id>0)
            {
                return Redirect("/cografya/details");
            }
            var detay = Main.GetById(id);
            return View(detay);

        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult List()
        {
            return View();

        }
    }
}        
