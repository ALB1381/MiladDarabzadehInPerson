using MiladDarabzadeh.Data.Entities.EnglishExam.Questions.AudioQuestions;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiladDarabzadeh.Data.Entities.EnglishExam.Questions.audioQuestionAnswers
{
    public class selectingAnswerQuestionedByAudio
    {
        

        [Key]
        public int AnswerId { get; set; }


        [Column(TypeName = "TINYINT")]
        public int Score { get; set; }


        public int audioQuestionAnsweredBySelectingId { get; set; }
        [ForeignKey("audioQuestionAnsweredBySelectingId")]
        public audioQuestionAnsweredBySelecting audioQuestionAnsweredBySelecting { get; set; }


        public int UserId { get; set; }


        [ForeignKey("UserId")]
        public User.User User { get; set; }


    }
}
