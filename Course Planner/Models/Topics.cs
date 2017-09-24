using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Course_Planner.Models
{
    public class Topics
    {
        [Key]
        public int Topic { get; set; }
        public string TopicName { get; set; }

    }
}