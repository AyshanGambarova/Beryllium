using Beryillium.DAL;
using Beryillium.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Beryillium.Controllers
{
    public class HomeController : Controller
    {
        private readonly ConnectToDb db;
        public HomeController(ConnectToDb _db)
        {
            db = _db;
        }

        public IActionResult Index()
        {
            HomeViewModel hvm = new HomeViewModel
            {
                Sliders=db.SLiders.ToList(),
                Section=db.Sections.FirstOrDefault(),
                Works=db.Works.ToList(),
                Testimonials=db.Testimonials.ToList(),
                News=db.News.Take(3).ToList(),
                Features=db.Features.ToList()
            };
            return View(hvm);
           
        }


       
     
    }
}
