using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContosoUniversityProject.Models
{
    public class Student
    {
        public int ID { get; set; }

        // The MaxLength attribute provides similar functionality to the StringLength
        // attribute but doesn't provide client side validation.
        [Required]
        [StringLength(50)]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "First name cannpt be longer that 50 characters.")]
        [Column("FirstName")]
        [Display(Name = "First Name")]
        public string FirstMidName { get; set; }

        // Value types cannot be assigned a null value, so they are inherently treated as required fields.
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Enrollment Date")]
        public DateTime EnrollmentDate { get; set; }

        [Display(Name = "Full Name")]
        public string FullName
        {
            get
            {
                return LastName + ", " + FirstMidName;
            }
        }

        // Below is a navigation property.
        // A Student entity can be associated with more than one Enrollment entity.
        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }
}