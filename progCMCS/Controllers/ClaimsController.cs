using Microsoft.AspNetCore.Mvc;
using progCMCS.Models;
using System.Collections.Generic;
using System;

namespace progCMCS.Controllers
{
    public class ClaimsController : Controller
    {
        private static List<Claim> claims = new List<Claim>();

        public IActionResult Index()
        {
            return View(claims);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Claim claim)
        {
            claim.ClaimID = claims.Count + 1;
            claim.Status = "Pending";
            claim.DateSubmitted = DateTime.Now;
            claims.Add(claim);
            return RedirectToAction("Index");
        }

        public IActionResult Review(int id)
        {
            var claim = claims.Find(c => c.ClaimID == id);
            return View(claim);
        }
    }
}
