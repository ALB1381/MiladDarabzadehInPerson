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
    public class selectingAnswerQuestionedByAudio
    {

        [Key]
        public int AnswerId { get; set; }

        [Column(TypeName = "TINYINT")]
        public int Score { get; set; }

        #region relation Id's
        public int UserId { get; set; }
        public int audioQuestionAnsweredBySelectingId { get; set; }
        #endregion

        #region relation connection's
        [ForeignKey("audioQuestionAnsweredBySelectingId")]
        public audioQuestionAnsweredBySelecting audioQuestionAnsweredBySelecting { get; set; }

        [ForeignKey("UserId")]
        public User.User User { get; set; }
        #endregion
    }
}
