using MiladDarabzadeh.Data.Entities.EnglishExam.Questions.AudioQuestions;
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

        public int? PictureQustionId { get; set; }
        public int? TextualQustionId { get; set; }
        public int? VideoQustionId { get; set; }


        [ForeignKey("PictureQustionId")]
        public pictureQuestion? PictureQuestion { get; set; }
        [ForeignKey("TextualQustionId")]
        public textualQuestion? TextualQuestion { get; set; }
        [ForeignKey("VideoQustionId")]
        public videoQuestion? VideoQuestion { get; set; }
        [ForeignKey("ExamId")]
        public Exam Exam { get; set; }




        public int? AudioQuestionAnsweredByAudioId { get; set; }
        [ForeignKey("AudioQuestionAnsweredByAudioId")]
        public audioQuestionAnsweredByAudio? AudioQuestionAnsweredByAudio { get; set; }

        public int? audioQuestionAnsweredBySelectingId { get; set; }
        [ForeignKey("audioQuestionAnsweredBySelectingId")]
        public audioQuestionAnsweredBySelecting? audioQuestionAnsweredBySelecting { get; set; }

    }
}
