using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContosoUniversityProject.Models
{
    public class OfficeAssignment
    {
        // The Entity Framework can't automatically recognize InstructorID as the primary key
        // of this entity because its name doesn't follow the ID or classnameID naming convention.
        // Therefore, the Key attribute is used to identify it as the key.
        [Key]
        [ForeignKey("Instructor")]
        public int InstructorID { get; set; }

        [StringLength(50)]
        [Display(Name = "Office Location")]
        public string Location { get; set; }

        public virtual Instructor Instructor { get; set; }
    }
}