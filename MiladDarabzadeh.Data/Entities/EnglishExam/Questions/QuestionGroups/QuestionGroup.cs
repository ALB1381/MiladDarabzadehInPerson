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
        public int QuestionGroupId { get; set; }

        public string QuestionGroupTitle { get; set; }

        public int? audioQuestionId { get; set; }
        public int? pictureQuestionId { get; set; }
        public int? textualQuestionId { get; set; }
        public int? videoQuestionId { get; set; }

        [ForeignKey("audioQuestionId")]
        public List<audioQuestion>? AudioQuestions { get; set; }

        [ForeignKey("pictureQuestionId")]
        public List<pictureQuestion>? PictureQuestions { get; set; }

        [ForeignKey("textualQuestionId")]
        public List<textualQuestion>? TextualQuestions { get; set; }

        [ForeignKey("videoQuestionId")]
        public List<videoQuestion>? VideoQuestions { get; set; }
    }
}
