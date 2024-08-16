﻿using MiladDarabzadeh.Data.Entities.EnglishExam.Questions.AudioQuestions;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MiladDarabzadeh.Data.Entities.EnglishExam.Questions.pictureQuestions;

namespace MiladDarabzadeh.Data.Entities.EnglishExam.Answers.pictureQuestionAnswers
{
    public class TextAnswerQuestionedByPicture
    {
        [Key]
        public int AnswerId { get; set; }

        public string AnswerText { get; set; }

        [Column(TypeName = "TINYINT")]
        public int Score { get; set; }


        #region relation Id's
        public int pictureQuestionAnsweredByTextId { get; set; }
        public int UserId { get; set; }
        #endregion

        #region relation connection's
        [ForeignKey("pictureQuestionAnsweredByTextId")]
        public pictureQuestionAnsweredByText PictureQuestionAnsweredByText { get; set; }

        [ForeignKey("UserId")]
        public User.User User { get; set; }
        #endregion

    }
}
