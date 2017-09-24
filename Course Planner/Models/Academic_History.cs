using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Course_Planner.Models
{
    public class Academic_History
    {
        [Key]
        public int history_Id { get; set; }

        public Users UserId { get; set; }
        public int userId { get; set; }

        public Course CourseCode { get; set; }
        public string courseCode { get; set; }

        public bool Passed { get; set; }
    }
}