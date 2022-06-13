using NguyenBinhMinh_Bigschool.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NguyenBinhMinh_Bigschool.ViewModels
{
    public class CoursesViewModel
    {
        public IEnumerable<Course> UpcommingCourse { get; set; }
        public bool ShowAction { set; get; }
    }
}