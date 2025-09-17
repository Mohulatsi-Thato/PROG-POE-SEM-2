using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using progCMCS.Models;

namespace progCMCS.Controllers
{
    public class ManagersController : Controller
    {
        private static List<Manager> managers = new List<Manager>();

        public IActionResult Index()
        {
            return View(managers);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Manager manager)
        {
            manager.ManagerID = managers.Count + 1;
            managers.Add(manager);
            return RedirectToAction("Index");
        }
    }
}
