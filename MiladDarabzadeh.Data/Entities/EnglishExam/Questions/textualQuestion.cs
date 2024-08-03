﻿using MiladDarabzadeh.Data.Entities.EnglishExam.Questions.Connections;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiladDarabzadeh.Data.Entities.EnglishExam.Questions
{
    public class textualQuestion
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int textualQuestionId { get; set; }

        [Display(Name = "راهنمای سوال ")]
        [MinLength(4, ErrorMessage = "{0} نمیتواند کمتر از {1} کارکتر باشد")]
        [MaxLength(60, ErrorMessage = "{0} نمیتواند بیشتر از {1} کارکتر باشد")]
        [Column(TypeName = "nvarchar(60)")]
        public string? QuestionGuide { get; set; }

        [Display(Name = "متن سوال")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        public string QuestionText { get; set; }


        public bool ShouldAnswerWithVoice { get; set; }

        public bool ShouldAnsweWithText { get; set; }

        public bool ShouldCameraRecord { get; set; }

        public bool doesItSelective { get; set; }

        public bool doesItMultipleSelective { get; set; }



        [Column(TypeName = "TINYINT")]
        public int? optionOneValue { get; set; }
        [Column(TypeName = "nvarchar(200)")]
        public string? optionOneText { get; set; }
        [Column(TypeName = "TINYINT")]
        public int? optionTwoValue { get; set; }
        [Column(TypeName = "nvarchar(200)")]
        public string? optionTwoText { get; set; }
        [Column(TypeName = "TINYINT")]
        public int? optionThreeValue { get; set; }
        [Column(TypeName = "nvarchar(200)")]
        public string? optionThreeText { get; set; }
        [Column(TypeName = "TINYINT")]
        public int? optionFourValue { get; set; }
        [Column(TypeName = "nvarchar(200)")]
        public string? optionFourText { get; set; }
        [Column(TypeName = "TINYINT")]
        public int? optionFiveValue { get; set; }
        [Column(TypeName = "nvarchar(200)")]
        public string? optionFiveText { get; set; }
        [Column(TypeName = "TINYINT")]
        public int? optionSixValue { get; set; }
        [Column(TypeName = "nvarchar(200)")]
        public string? optionSixText { get; set; }



        public int QuestionGroupId { get; set; }

        [ForeignKey("QuestionGroupId")]
        public QuestionGroups.QuestionGroup QuestionGroup { get; set; }

        public List<questionExamConnection> QuestionExamConnections { get; set; }
    }
}
