using Course_Planner.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Course_Planner.UserControls;
using Course_Planner.ViewModels;

namespace Course_Planner.Controllers
{
    


    public class Academic_HistoryController : Controller
    {
        private ApplicationDbContext _context;

        public Academic_HistoryController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        

        // GET: Academic_History
        public ActionResult Index()
        {
            ValidUser Idverifier = new ValidUser();

            var modeldata = new AcademicViewModel();
            modeldata.FullCourseList = _context.Courses.ToList();
            modeldata.FullAcademicHistory = _context.Academic_Historys.ToList();
            modeldata.Id = Idverifier.FindId(User.Identity.Name);
            return View(modeldata);
        }
    }
}