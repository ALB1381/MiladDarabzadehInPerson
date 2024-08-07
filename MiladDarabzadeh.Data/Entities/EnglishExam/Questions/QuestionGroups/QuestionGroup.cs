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

namespace MiladDarabzadeh.Data.Entities.EnglishExam.Questions.QuestionGroups
{
    public class QuestionGroup
    {
        [Key]
        [Column(TypeName = "TINYINT")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int QuestionGroupId { get; set; }

        public string QuestionGroupTitle { get; set; }




        public List<audioQuestionAnsweredByAudio>? AudioQuestionAnsweredByAudios { get; set; }
        public List<audioQuestionAnsweredBySelecting>? audioQuestionAnsweredBySelecting { get; set; }

        public List<audioQuestionAnsweredByText>? AudioQuestionAnsweredByTexts { get; set; }

        /// <summary>
        /// /////////////////////////////////
        /// </summary>

        public List<pictureQuestionAnsweredBySelecting>? PictureQuestionAnsweredBySelectings { get; set; }
        public List<pictureQuestionAnsweredByText>? PictureQuestionAnsweredByTexts { get; set; }
        public List<PictureQuestionAnsweredByAudio>? PicureQuestionAnsweredByAudios { get; set; }

        //////////////////////////////////
        ///


        public List<textualQuestionAnsweredByAudio>? TextualQuestionAnsweredByAudios { get; set; }
        public List<textualQuestionAnsweredBySelecting>? textualQuestionAnsweredBySelectings { get; set; }
        public List<textualQuestionAnsweredByText>? textualQuestionAnsweredByTexts { get; set; }

        //////////////////
        ///
        public List<videoQuestionAnsweredByAudio>? VideoQuestionAnsweredByAudios { get; set; }
        public List<videoQuestionAnsweredBySelecting>? videoQuestionAnsweredBySelecting { get; set; }
        public List<videoQuestionAnsweredByText>? videoQuestionAnsweredByText { get; set; }
    }
}
