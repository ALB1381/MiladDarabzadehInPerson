﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MiladDarabzadeh.Data.Entities.EnglishExam.Questions.Connections;

namespace MiladDarabzadeh.Data.Entities.EnglishExam.Questions.pictureQuestions
{
    public class PictureQuestionAnsweredByAudio
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int pictureQuestionId { get; set; }

        [Display(Name = "راهنمای سوال ")]
        [MinLength(4, ErrorMessage = "{0} نمیتواند کمتر از {1} کارکتر باشد")]
        [MaxLength(60, ErrorMessage = "{0} نمیتواند بیشتر از {1} کارکتر باشد")]
        [Column(TypeName = "nvarchar(60)")]
        public string? QuestionGuide { get; set; }

        [Display(Name = "متن سوال")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MinLength(4, ErrorMessage = "{0} نمیتواند کمتر از {1} کارکتر باشد")]
        [MaxLength(400, ErrorMessage = "{0} نمیتواند بیشتر از {1} کارکتر باشد")]
        [Column(TypeName = "nvarchar(800)")]
        public string QuestionText { get; set; }

        [Display(Name = "تصویر سوال")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [Column(TypeName = "nvarchar(70)")]
        public string imageFileName { get; set; }

        [Column(TypeName = "TINYINT")]
        public int? FixedScore { get; set; }
        public bool ShouldCameraRecord { get; set; }

        public int QuestionGroupId { get; set; }

        [ForeignKey("QuestionGroupId")]
        public QuestionGroups.QuestionGroup QuestionGroup { get; set; }

        public List<questionExamConnection>? QuestionExamConnections { get; set; }
    }
}