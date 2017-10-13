using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Course_Planner.Models;
using Course_Planner.UserControls;
using Course_Planner.ViewModels;

namespace Course_Planner.Controllers
{
    public class Selected_CourseController : Controller
    {
        private ApplicationDbContext _context;

        public Selected_CourseController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        // GET: Selected_Course
        public ActionResult Index()
        {
            ValidUser idverifier = new ValidUser();

            var viewmodeldata = new CourseSelectViewModel();
            viewmodeldata.FullCourseList = _context.Courses.ToList();
            viewmodeldata.FullAcademicHistory = _context.Academic_Historys.ToList();
            viewmodeldata.FullSelectedCourses = _context.Selected_courses.ToList();
            viewmodeldata.Id = idverifier.FindId(User.Identity.Name);


            return View(viewmodeldata);
        }

        [HttpPost]
        public ActionResult Save(Selected_Course selected_course)
        {
            _context.Selected_courses.Add(selected_course);
            _context.SaveChanges();

            return RedirectToAction("Index", "Selected_Course");
        }
    }
}