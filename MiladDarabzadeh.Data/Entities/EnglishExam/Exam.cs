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

        //For the questions we need to be able to upload a audio and video and picture file unrequired for each question.
        //We need a text box for each question which is requered.
        //We need two to six options for each questions with text for each option.
        //All of the questions will have two options: 1-some of theme should be multipel chose and 2-some of theme can be single choise.
        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //For all questions we can have audio answer option.
        //For some questions we should have record buttons for audio answer for speaking test.
        //All the lestining qustions should have limit for playing.
        //All the option should have value.
        //Some questions should be describe and they will not have any options to choice.
        //Make group of test.
        //For writing qustions we have just a value and the teacher of the class should qualify it.
        //For speaking we can just take a value for each qustion.
        //Question List
    }
}
