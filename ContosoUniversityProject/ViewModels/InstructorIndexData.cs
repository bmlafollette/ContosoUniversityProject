using ContosoUniversityProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ContosoUniversityProject.ViewModels
{
    public class InstructorIndexData
    {
        // Each holds the data for one of the tables on the Instructors page.
        public IEnumerable<Instructor> Instructors { get; set; }
        public IEnumerable<Course> Courses { get; set; }
        public IEnumerable<Enrollment> Enrollments { get; set; }
    }
}