using MiladDarabzadeh.Data.Entities.EnglishExam.Questions.AudioQuestions;
using MiladDarabzadeh.Data.Entities.User;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiladDarabzadeh.Data.Entities.EnglishExam.Questions.audioQuestionAnswers
{
    public class audioAnswerQuestionedByAudio
    {
        [Key]
        public int AnswerId { get; set; }


        public string? FileName { get; set; }


        [Column(TypeName = "TINYINT")]
        public int Score { get; set; }


        public int audioQuestionAnsweredByAudioId { get; set; }


        [ForeignKey("audioQuestionAnsweredByAudioId")]
        public audioQuestionAnsweredByAudio audioQuestionAnsweredByAudio { get; set; }


        public int UserId { get; set; }


        [ForeignKey("UserId")]
        public User.User User { get; set; }

    }
}
