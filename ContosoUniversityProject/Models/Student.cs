using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ContosoUniversityProject.Models
{
    public class Student
    {
        public int ID { get; set; }
        public string LastName { get; set; }
        public string FirstMidName { get; set; }
        public DateTime EnrollmentDate { get; set; }

        // Below is a navigation property.
        // A Student entity can be associated with more than one Enrollment entity.
        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }
}