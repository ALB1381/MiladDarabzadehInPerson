using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiladDarabzadeh.Data.Entities.EnglishExam.Questions.Connections
{
    public class questionExamConnection
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int QuestionExamConnectionId { get; set; }

        public int ExamId { get; set; }

        public int? AudioQuestionId { get; set; }
        public int? PictureQustionId { get; set; }
        public int? TextualQustionId { get; set; }
        public int? VideoQustionId { get; set; }

        public audioQuestion? AudioQuestion { get; set; }
        public pictureQuestion? PictureQuestion { get; set; }
        public textualQuestion? TextualQuestion { get; set; }
        public videoQuestion? VideoQuestion { get; set; }
        public Exam Exam { get; set; }

    }
}
