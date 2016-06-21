using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FitLogGo.Models;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace FitLogGo.Controllers
{
    public class SessionsController : Controller
    {
        private FitLogGoDbContext _context;

        public SessionsController(FitLogGoDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View(_context.Sessions.ToList());
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Session session)
        {
            if (ModelState.IsValid)
            {
                _context.Sessions.Add(session);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(session);
        }
    }
}
