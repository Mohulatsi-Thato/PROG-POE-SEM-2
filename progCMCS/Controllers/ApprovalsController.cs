using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using progCMCS.Models;

namespace progCMCS.Controllers
{
    public class ApprovalsController : Controller
    {
        private static List<Approval> approvals = new List<Approval>();

        public IActionResult Index()
        {
            return View(approvals);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Approval approval)
        {
            approval.ApprovalID = approvals.Count + 1;
            approval.ApprovalDate = DateTime.Now;
            approvals.Add(approval);
            return RedirectToAction("Index");
        }
    }
}
