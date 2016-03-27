using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace FacultyApplicants.Models
{
    public class ApplicantsContext : DbContext
    {
        public DbSet<BranchOfLearning> Reviews { get; set; }

        public DbSet<Applicant> Albums { get; set; }
    }
}