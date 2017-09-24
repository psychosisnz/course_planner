using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Course_Planner.Models;

namespace Course_Planner.ViewModels
{
    public class CourseSelectViewModel
    {
        public List<Course> FullCourseList { get; set; }

        public List<Academic_History> FullAcademicHistory { get; set; }

        public List<Selected_Course> FullSelectedCourses { get; set; }

        public int Id { get; set; }


    }
}