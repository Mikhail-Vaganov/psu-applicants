using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FacultyApplicants.Models
{
    public class BranchOfLearning
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Название направления")]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Факультет")]
        public string Faculty { get; set; }
    }
}