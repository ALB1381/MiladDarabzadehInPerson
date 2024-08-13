using MiladDarabzadeh.Data.Entities.EnglishExam.Questions.AudioQuestions;
using MiladDarabzadeh.Data.Entities.EnglishExam.Questions.pictureQuestions;
using MiladDarabzadeh.Data.Entities.EnglishExam.Questions.TextualQuestions;
using MiladDarabzadeh.Data.Entities.EnglishExam.Questions.videoQuestions;
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



        [ForeignKey("ExamId")]
        public Exam Exam { get; set; }



        /// <summary>
        /// ///////////////////////////////// Audio Questions connections
        /// </summary>
        public int? AudioQuestionAnsweredByAudioId { get; set; }
        [ForeignKey("AudioQuestionAnsweredByAudioId")]
        public audioQuestionAnsweredByAudio? AudioQuestionAnsweredByAudio { get; set; }

        public int? audioQuestionAnsweredBySelectingId { get; set; }
        [ForeignKey("audioQuestionAnsweredBySelectingId")]
        public audioQuestionAnsweredBySelecting? audioQuestionAnsweredBySelecting { get; set; }

        public int? audioQuestionAnsweredByTextId { get; set; }
        [ForeignKey("audioQuestionAnsweredByTextId")]
        public audioQuestionAnsweredByText? AudioQuestionAnsweredByText { get; set; }


        /// <summary>
        /// /////////////////////////////////////////////// Picture Question Connections
        /// </summary>


        public int? PictureQuestionAnsweredByAudioId { get; set; }
        [ForeignKey("PictureQuestionAnsweredByAudioId")]
        public PictureQuestionAnsweredByAudio? PictureQuestionAnsweredByAudio { get; set; }
        public int? pictureQuestionAnsweredBySelectingId { get; set; }
        [ForeignKey("pictureQuestionAnsweredBySelectingId")]
        public pictureQuestionAnsweredBySelecting? pictureQuestionAnsweredBySelecting { get; set; }
        public int? pictureQuestionAnsweredByTextId { get; set; }
        [ForeignKey("pictureQuestionAnsweredByTextId")]
        public pictureQuestionAnsweredByText? pictureQuestionAnsweredByText { get; set; }

        /////////////////////////////////
        /// <summary>
        ///  Textual Question connections
        /// </summary>
        /// 

        public int? TextualQuestionAnsweredByAudioId { get; set; }
        [ForeignKey("TextualQuestionAnsweredByAudioId")]
        public textualQuestionAnsweredByAudio? TextualQuestionAnsweredByAudio { get; set; }
        public int? textualQuestionAnsweredBySelectingId { get; set; }
        [ForeignKey("textualQuestionAnsweredBySelectingId")]
        public textualQuestionAnsweredBySelecting? textualQuestionAnsweredBySelecting { get; set; }
        public int? textualQuestionAnsweredByTextId { get; set; }
        [ForeignKey("textualQuestionAnsweredByTextId")]
        public textualQuestionAnsweredByText? textualQuestionAnsweredByText { get; set; }


        ///////////////////////////////
        /// <summary>
        /// Video Question Connections
        /// </summary>
        /// 
        public int? VideoQuestionAnsweredByAudioId { get; set; }
        [ForeignKey("VideoQuestionAnsweredByAudioId")]
        public videoQuestionAnsweredByAudio? VideoQuestionAnsweredByAudio { get; set; }

        public int? videoQuestionAnsweredBySelectingId { get; set; }
        [ForeignKey("videoQuestionAnsweredBySelectingId")]
        public videoQuestionAnsweredBySelecting? videoQuestionAnsweredBySelecting { get; set; }

        public int? videoQuestionAnsweredByTextId { get; set; }
        [ForeignKey("videoQuestionAnsweredByTextId")]
        public videoQuestionAnsweredByText? videoQuestionAnsweredByText { get; set; }


    }
}
