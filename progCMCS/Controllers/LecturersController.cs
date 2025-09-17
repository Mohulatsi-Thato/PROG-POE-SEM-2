using System.Collections.Generic;
using progCMCS.Models;
using Microsoft.AspNetCore.Mvc;

namespace progCMCS.Controllers
{
    public class LecturersController : Controller
    {
        private static List<Lecturer> lecturers = new List<Lecturer>();

        public IActionResult Index()
        {
            return View(lecturers);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Lecturer lecturer)
        {
            lecturer.LecturerID = lecturers.Count + 1;
            lecturers.Add(lecturer);
            return RedirectToAction("Index");
        }
    }
}
