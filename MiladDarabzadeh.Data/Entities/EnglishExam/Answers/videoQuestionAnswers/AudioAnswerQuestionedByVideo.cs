using MiladDarabzadeh.Data.Entities.EnglishExam.Questions.TextualQuestions;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MiladDarabzadeh.Data.Entities.EnglishExam.Questions.videoQuestions;

namespace MiladDarabzadeh.Data.Entities.EnglishExam.Answers.videoQuestionAnswers
{
    public class AudioAnswerQuestionedByVideo
    {
        [Key]
        public int AnswerId { get; set; }

        public string? FileName { get; set; }

        [Column(TypeName = "TINYINT")]
        public int Score { get; set; }

        #region relation Id's
        public int videoQuestionAnsweredByAudioId { get; set; }
        public int UserId { get; set; }
        #endregion

        #region relation connection's
        [ForeignKey("videoQuestionAnsweredByAudioId")]
        public videoQuestionAnsweredByAudio VideoQuestionAnsweredByAudio { get; set; }

        [ForeignKey("UserId")]
        public User.User User { get; set; }
        #endregion
    }
}
