using MiladDarabzadeh.Data.Entities.EnglishExam.Questions.AudioQuestions;
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

        public List<audioQuestion>? AudioQuestions { get; set; }

        public List<pictureQuestion>? PictureQuestions { get; set; }

        public List<textualQuestion>? TextualQuestions { get; set; }
        public List<videoQuestion>? VideoQuestions { get; set; }

        public List<audioQuestionAnsweredByAudio> AudioQuestionAnsweredByAudios { get; set; }
        public List<audioQuestionAnsweredBySelecting> audioQuestionAnsweredBySelecting { get; set; }
    }
}
