using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ContosoUniversityProject.Models
{
    public class Student
    {
        public int ID { get; set; }
        // The MaxLength attribute provides similar functionality to the StringLengt
        // attribute but doesn't provide client side validation.
        [StringLength(50)]
        public string LastName { get; set; }
        [StringLength(50, ErrorMessage = "First name cannpt be longer that 50 characters.")]
        public string FirstMidName { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime EnrollmentDate { get; set; }

        // Below is a navigation property.
        // A Student entity can be associated with more than one Enrollment entity.
        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }
}