using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContosoUniversityProject.Models
{
    public class Course
    {
        // Below attribute lets you enter the primary key rather than having the databse generate it.
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CourseID { get; set; }
        public string Title { get; set; }
        public int Credits { get; set; }

        // A Course entity can be related to any number of Enrollment entities.
        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }
}