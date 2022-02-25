using Beryillium.DAL;
using Beryillium.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Beryillium.Controllers
{
    public class SearchController : Controller
    {
        private readonly ConnectToDb db;
        public SearchController(ConnectToDb _db)
        {
            db = _db;
        }

        public IActionResult Index()
        {
            return View(db.Works.ToList());
        }


        public IActionResult GetData()
        {
            return PartialView("_WorksPartial", db.Works.ToList());
        }
        public IActionResult SearchWorks(string query)
        {
            List<Work> result = db.Works.Where(x => x.Subtitle.ToLower().Contains(query.ToLower())).ToList();
            return PartialView("_WorksPartial", result);
        }
    }
}
