using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContosoUniversityProject.Models
{
    public class Student : Person
    {
        // Value types cannot be assigned a null value, so they are inherently treated as required fields.
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Enrollment Date")]
        public DateTime EnrollmentDate { get; set; }

        // Below is a navigation property.
        // A Student entity can be associated with more than one Enrollment entity.
        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }
}