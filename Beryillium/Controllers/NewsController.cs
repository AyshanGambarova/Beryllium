using Beryillium.DAL;
using Beryillium.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Beryillium.Controllers
{
    public class NewsController : Controller
    {
        private readonly ConnectToDb db;
        public NewsController(ConnectToDb _db)
        {
            db = _db;
        }
        public IActionResult Index()
        {
            List<News> news = db.News.Skip(3).ToList();
            return View(news);
        }
    }
}
