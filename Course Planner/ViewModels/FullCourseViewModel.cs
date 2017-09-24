using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Course_Planner.Models;
using Microsoft.Ajax.Utilities;

namespace Course_Planner.ViewModels
{
    public class FullCourseViewModel
    {
        public List<Course> Courselist { get; set; }
        public int Id { get; set; }
    }
    
}