using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Course_Planner.UserControls;
using Course_Planner.Models;

namespace Course_Planner.Controllers
{
    public class CourseController : Controller
    {
        private ApplicationDbContext _context;

        public CourseController()
        {
            //try
            //{
            //    ValidUser uservalidator = new ValidUser();
            //    uservalidator.FindId(User.Identity.Name);
            //}
            //catch
            //{
                
            //}
            _context = new ApplicationDbContext();

        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        // GET: Course
        public ActionResult Index()
        {
            ValidUser uservalidator = new ValidUser();
            var currentid = uservalidator.FindId(User.Identity.Name);

            var Viewmodeldata = new ViewModels.FullCourseViewModel();
            Viewmodeldata.Courselist = FullCourseList();
            Viewmodeldata.Id = currentid;
            return View(Viewmodeldata);
        }

        public List<Course> FullCourseList()
        {
            var FullCourseList = new List<Course>();
            foreach (var item in _context.Courses)
            {
                FullCourseList.Add(item);
            }
            return FullCourseList;
                    }
        
    }
}