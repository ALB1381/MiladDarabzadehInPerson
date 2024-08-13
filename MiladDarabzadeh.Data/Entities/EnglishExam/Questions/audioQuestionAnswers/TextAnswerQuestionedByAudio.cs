using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiladDarabzadeh.Data.Entities.EnglishExam.Questions.audioQuestionAnswers
{
    public class TextAnswerQuestionedByAudio
    {
        [Key]
        public int AnswerId { get; set; }

        public string AnswerText { get; set; }


        [Column(TypeName = "TINYINT")]
        public int Score { get; set; }




        public int audioQuestionAnsweredBytext { get; set; }

        public int UserId { get; set; }
        [ForeignKey("UserId")]
        public User.User User { get; set; }
    }
}
