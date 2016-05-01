using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ContosoUniversityProject.Models
{
    public enum Grade
    {
        A, B, C, D, F
    }

    public class Enrollment
    {
        public int EnrollmentID { get; set; }
        // A foreign key with a corresponding navigation property below.
        public int CourseID { get; set; }
        // A foreign key with a corresponding navigation property below.
        public int StudentID { get; set; }
        public Grade? Grade { get; set; }

        // Below are navigation properties.
        // An enrollment entity is only associated with a single Student entity.
        public virtual Course Course { get; set; }
        public virtual Student Student { get; set; }
    }
}