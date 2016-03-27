using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FacultyApplicants.Models
{
    public class Applicant
    {
        public int Id { get; set; }

        [Required]
        [Display(Name="Имя")]
        public string FirstName { get; set; }

        [Required]
        [Display(Name = "Фамилия")]
        public string SecondName { get; set; }

        [Required]
        [Display(Name = "Отчество")]
        public string Patronymic { get; set; }

        [Required]
        [Display(Name = "Суммарный бал ЕГЭ")]
        public int ExamPoints { get; set; }

        [Display(Name = "Оригинал аттестата")]
        public bool OriginalCertificate { get; set; }



        public int FirstPriorityBranchID { get; set; }
        [Display(Name = "Приоритет 1")]
        public virtual BranchOfLearning FirstPriorityBranch { get; set; }


        public int SecondPriorityBranchID { get; set; }
        [Display(Name = "Приоритет 2")]
        public virtual BranchOfLearning SecondPriorityBranch { get; set; }


        public int ThirdPriorityBranchID { get; set; }
        [Display(Name = "Приоритет 3")]
        public virtual BranchOfLearning ThirdPriorityBranch { get; set; }


        [Display(Name = "Нужно общежитие")]
        public bool NeedDormitory { get; set; }


        [Display(Name = "Обучение по бюджету")]
        public bool BudgetEducation { get; set; }


        [Display(Name = "Комментарй")]
        public string Comment { get; set; }

        [Required]
        [Display(Name = "Заявление")]
        public bool Application { get; set; }
    }
}