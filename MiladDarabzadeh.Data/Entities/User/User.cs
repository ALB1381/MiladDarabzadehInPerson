using MiladDarabzadeh.Data.Entities.Course;
using MiladDarabzadeh.Data.Entities.EnglishExam.Answers.audioQuestionAnswers;
using MiladDarabzadeh.Data.Entities.EnglishExam.Answers.pictureQuestionAnswers;
using MiladDarabzadeh.Data.Entities.EnglishExam.Answers.textualQuestionAnswers;
using MiladDarabzadeh.Data.Entities.EnglishExam.Answers.videoQuestionAnswers;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiladDarabzadeh.Data.Entities.User
{
    public class User
    {
        #region Column
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int UserId { get; set; }

        [Display(Name = "نام کاربری")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(60, ErrorMessage = "{0} نمیتواند بیشتر از {1} کارکتر باشد")]
        [MinLength(4, ErrorMessage = "{0} نمیتواند کمتر از {1} کارکتر باشد")]
        [Column(TypeName = "nvarchar(60)")]
        public string UserName { get; set; }

        [Display(Name = "نام و نام خانوادگی")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(70, ErrorMessage = "{0} نمیتواند بیشتر از {1} کارکتر باشد")]
        [MinLength(4, ErrorMessage = "{0} نمیتواند کمتر از {1} کارکتر باشد")]
        [Column(TypeName = "nvarchar(70)")]
        public string UserNandF { get; set; }

        [Display(Name = "ایمیل")]
        [MaxLength(90, ErrorMessage = "{0} نمیتواند بیشتر از {1} کارکتر باشد")]
        [MinLength(4, ErrorMessage = "{0} نمیتواند کمتر از {1} کارکتر باشد")]
        [Column(TypeName = "nvarchar(90)")]
        public string? UserEmail { get; set; }

        [Display(Name = "شماره تماس")]
        [MaxLength(16, ErrorMessage = "{0} نمیتواند بیشتر از {1} کارکتر باشد")]
        [MinLength(9, ErrorMessage = "{0} نمیتواند کمتر از {1} کارکتر باشد")]
        [Column(TypeName = "nvarchar(16)")]
        public string UserPhoneNumber { get; set; }

        [Display(Name = "تاریخ ثبت نام")]
        public DateTime UserRegisterDate { get; set; } = DateTime.Now;

        [Display(Name = "آواتار")]
        public string UserAvatar { get; set; }

        [Display(Name = "کد فعال سازی ایمیل")]
        [MaxLength(50, ErrorMessage = "{0} نمیتواند بیشتر از {1} کارکتر باشد")]
        [Column(TypeName = "nvarchar(50)")]
        public string? UserActiveCodeForEmail { get; set; }

        [Display(Name = "کد فعال سازی شماره تلقن")]
        [MaxLength(50, ErrorMessage = "{0} نمیتواند بیشتر از {1} کارکتر باشد")]
        [Column(TypeName = "nvarchar(50)")]
        public string UserActiveCodeForPhoneNumber { get; set; }

        [Display(Name = "رمز ورود")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(80, ErrorMessage = "{0} نمیتواند بیشتر از {1} کارکتر باشد")]
        [MinLength(8, ErrorMessage = "{0} نمیتواند کمتر از {1} کارکتر باشد")]
        [Column(TypeName = "nvarchar(80)")]
        public string UserPassword { get; set; }

        public DateOnly? BirthDate { get; set; }

        public bool IsActived { get; set; }

        #endregion
        
        #region Relation Ids
        public int RoleId { get; set; }
        #endregion

        #region Relation
        [ForeignKey("RoleId")]
        public Role Role { get; set; }

        public List<Course.Course>? TeacherCourses { get; set; }
        #endregion

        /// <summary>
        /// ///////////////////////////
        /// </summary>
        public List<audioAnswerQuestionedByAudio>? AudioAnswerQuestionedByAudios { get; set; }

        public List<selectingAnswerQuestionedByAudio>? SelectingAnswerQuestionedByAudios { get; set; }

        public List<TextAnswerQuestionedByAudio>? TextAnswerQuestionedByAudios { get; set; }

        ////////////////////////////////////
        ///
        public List<AudioAnswerQuestionedByPicture> AudioAnswerQuestionedByPictures { get; set; }

        public List<SelectingAnswerQuestionedByPicture> SelectingAnswerQuestionedByPictures { get; set; }

        public List<TextAnswerQuestionedByPicture> TextAnswerQuestionedByPictures { get; set; }

        ///////////////////////
        ///

        public List<AudioAnswerQuestionedByText> AudioAnswerQuestionedByTexts { get; set; }
        public List<SelectingAnswerQuestionedByText> SelectingAnswerQuestionedByTexts { get; set; }
        public List<TextAnswerQuestionedByText> TextAnswerQuestionedByTexts { get; set; }

        ///////////////
        ///
        public List<AudioAnswerQuestionedByVideo> AudioAnswerQuestionedByVideos { get; set; }
        public List<SelectingAnswerQuestionedByVideo> SelectingAnswerQuestionedByVideos { get; set; }
        public List<TextAnswerQuestionedByVIdeo> TextAnswerQuestionedByVIdeos { get; set; }


    }
}
