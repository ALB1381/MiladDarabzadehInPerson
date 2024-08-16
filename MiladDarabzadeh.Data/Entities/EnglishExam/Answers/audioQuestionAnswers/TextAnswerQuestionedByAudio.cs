using MiladDarabzadeh.Data.Entities.EnglishExam.Questions.AudioQuestions;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiladDarabzadeh.Data.Entities.EnglishExam.Answers.audioQuestionAnswers
{
    public class TextAnswerQuestionedByAudio
    {
        [Key]
        public int AnswerId { get; set; }

        public string AnswerText { get; set; }

        [Column(TypeName = "TINYINT")]
        public int Score { get; set; }


        #region relation Id's
        public int audioQuestionAnsweredBytextId { get; set; }
        public int UserId { get; set; }
        #endregion

        #region relation connection's
        [ForeignKey("audioQuestionAnsweredBytextId")]
        public audioQuestionAnsweredByText AudioQuestionAnsweredByText { get; set; }

        [ForeignKey("UserId")]
        public User.User User { get; set; }
        #endregion

    }
}
