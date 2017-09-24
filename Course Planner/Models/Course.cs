using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Course_Planner.Models;

namespace Course_Planner.Models
{
    public class Course
    {
        [Key]
        public string CourseCode { get; set; }        
        public string CourseName { get; set; }
        public string Description { get; set; }
        public string Semester { get; set; }
        public string Pre_Reqs { get; set; }
        public bool Compulsory { get; set; }
        public Topics Topics { get; set; }
        public int Topic { get; set; }
        
   
    }
}