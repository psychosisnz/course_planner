using Course_Planner.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Course_Planner.Controllers
{
    public class TopicsController : Controller
    {
        private ApplicationDbContext _context;

        public TopicsController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();  
        }


        // GET: Topics
        public ActionResult Index()
        {
            // not sure if a index is needed for this controller yet, as unlikey will need to display topics in an editible list

            // generates a list that can be passed to view
            var topics = _context.Topics.ToList();

            return View();
        }
    }
}