using System;
using System.ComponentModel.DataAnnotations;

namespace ContosoUnversityWeb.Models
{
    public class StudentMetadata
    {
        [StringLength(50)]
        [Display(Name = "Last Name")]
        public string LastName;

        [StringLength(50)]
        [Display(Name = "First Name")]
        public string FirstName;

        [StringLength(50)]
        [Display(Name = "Middle Name")]
        public string MiddleName;

        [Display(Name = "Enrollment Date")]
        public Nullable<DateTime> EnrollmentDate;
    }

    public class EnrollmentMetadata
    {
        [Range(0, 4)]
        public Nullable<decimal> Grade;
    }
}