using MiladDarabzadeh.Data.Entities.Course;
using MiladDarabzadeh.Data.Entities.User.Connections;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiladDarabzadeh.Data.Entities.EnglishExam
{
    public class Exam
    {
        [Key]
        public int ExamId { get; set; }

        [Display(Name = "نام تست")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(20, ErrorMessage = "{0} نمیتواند بیشتر از {1} کارکتر باشد")]
        [MinLength(4, ErrorMessage = "{0} نمیتواند کمتر از {1} کارکتر باشد")]
        [Column(TypeName = "nvarchar(20)")]
        public string ExamName { get; set; }
        
        public int CountOfQuestions { get; set; }

        [Column(TypeName = "smallint")]
        public int? Time { get; set; }

        
        public int CycleId { get; set; }

        [ForeignKey("CycleId")]
        public CourseCycle CourseCycle { get; set; }

        public List<UserScoreExam> UserScoreExams { get; set; }

        //Question List
    }
}
