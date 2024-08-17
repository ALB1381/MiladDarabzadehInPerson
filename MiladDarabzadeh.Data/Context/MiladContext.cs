using Microsoft.EntityFrameworkCore;
using MiladDarabzadeh.Data.Entities.Course;
using MiladDarabzadeh.Data.Entities.Course.Connections;
using MiladDarabzadeh.Data.Entities.Discount;
using MiladDarabzadeh.Data.Entities.EnglishExam;
using MiladDarabzadeh.Data.Entities.EnglishExam.Answers.audioQuestionAnswers;
using MiladDarabzadeh.Data.Entities.EnglishExam.Answers.pictureQuestionAnswers;
using MiladDarabzadeh.Data.Entities.EnglishExam.Answers.textualQuestionAnswers;
using MiladDarabzadeh.Data.Entities.EnglishExam.Answers.videoQuestionAnswers;
using MiladDarabzadeh.Data.Entities.EnglishExam.Connections;
using MiladDarabzadeh.Data.Entities.EnglishExam.Questions.AudioQuestions;
using MiladDarabzadeh.Data.Entities.EnglishExam.Questions.Connections;
using MiladDarabzadeh.Data.Entities.EnglishExam.Questions.pictureQuestions;
using MiladDarabzadeh.Data.Entities.EnglishExam.Questions.QuestionGroups;
using MiladDarabzadeh.Data.Entities.EnglishExam.Questions.TextualQuestions;
using MiladDarabzadeh.Data.Entities.EnglishExam.Questions.videoQuestions;
using MiladDarabzadeh.Data.Entities.Order;
using MiladDarabzadeh.Data.Entities.User;
using MiladDarabzadeh.Data.Entities.User.Connections;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiladDarabzadeh.Data.Context
{
    public class MiladContext : DbContext
    {
        public MiladContext(DbContextOptions<MiladContext> options) : base(options)
        {

        }
        //Tables
        public DbSet<CourseModelConnection> CourseModelConnections { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<CourseCycle> CourseCycles { get; set; }
        public DbSet<CourseGroup> CourseGroups { get; set; }
        public DbSet<CourseLevel> CourseLevels { get; set; }
        public DbSet<CourseModel> CourseModels { get; set; }
        public DbSet<CycleModel> CycleModels { get; set; }
        public DbSet<SubCycle> SubCycles { get; set; }
        public DbSet<CourseDiscount> CourseDiscounts { get; set; }
        public DbSet<OrderDiscount> OrderDiscounts { get; set; }
        /// <summary>
        /// ///////////////////
        /// </summary>
        public DbSet<audioAnswerQuestionedByAudio> AudioAnswerQuestionedByAudios { get; set; }
        public DbSet<selectingAnswerQuestionedByAudio> selectingAnswerQuestionedByAudios { get; set; }
        public DbSet<TextAnswerQuestionedByAudio> TextAnswerQuestionedByAudios { get; set; }
        /// <summary>
        /// //////////////////
        /// </summary>
        public DbSet<AudioAnswerQuestionedByPicture> AudioAnswerQuestionedByPictures { get; set; }
        public DbSet<SelectingAnswerQuestionedByPicture> SelectingAnswerQuestionedByPictures { get; set; }
        public DbSet<TextAnswerQuestionedByPicture> TextAnswerQuestionedByPictures { get; set; }
        //////////
        /// <summary>
        /// 
        /// </summary>
        public DbSet<AudioAnswerQuestionedByText> AudioAnswerQuestionedByTexts { get; set; }
        public DbSet<SelectingAnswerQuestionedByText> SelectingAnswerQuestionedByTexts { get; set; }
        public DbSet<TextAnswerQuestionedByText> TextAnswerQuestionedByTexts { get; set; }
        /// <summary>
        /// ////////////
        /// </summary>
        public DbSet<AudioAnswerQuestionedByVideo> AudioAnswerQuestionedByVideos { get; set; }
        public DbSet<SelectingAnswerQuestionedByVideo> SelectingAnswerQuestionedByVideos { get; set; }
        public DbSet<TextAnswerQuestionedByVIdeo> TextAnswerQuestionedByVIdeos { get; set; }
        /// <summary>
        /// /////////
        /// </summary>
        public DbSet<ExamCycleConnection> ExamCycleConnections { get; set; }
        public DbSet<audioQuestionAnsweredByAudio> AudioQuestionAnsweredByAudios { get; set; }
        public DbSet<audioQuestionAnsweredBySelecting> AudioQuestionAnsweredBySelectings { get; set; }
        public DbSet<audioQuestionAnsweredByText> AudioQuestionAnsweredByTexts { get; set; }
        /// <summary>
        /// /////
        /// </summary>
        public DbSet<questionExamConnection> QuestionExamConnections { get; set; }
        public DbSet<PictureQuestionAnsweredByAudio> PictureQuestionAnsweredByAudios { get; set; }
        public DbSet<pictureQuestionAnsweredBySelecting> PictureQuestionAnsweredBySelectings { get; set; }
        public DbSet<pictureQuestionAnsweredByText> PictureQuestionAnsweredByTexts { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public DbSet<QuestionGroup> QuestionGroups { get; set; }
        public DbSet<textualQuestionAnsweredByAudio> TextualQuestionAnsweredByAudios { get; set; }
        public DbSet<textualQuestionAnsweredBySelecting> TextualQuestionAnsweredBySelectings { get; set; }
        public DbSet<textualQuestionAnsweredByText> TextualQuestionAnsweredByTexts { get; set; }
        /// <summary>
        /// ////
        /// </summary>
        public DbSet<videoQuestionAnsweredByAudio> VideoQuestionAnsweredByAudios { get; set; }
        public DbSet<videoQuestionAnsweredBySelecting> VideoQuestionAnsweredBySelectings { get; set; }
        public DbSet<videoQuestionAnsweredByText> VideoQuestionAnsweredByTexts { get; set; }
        public DbSet<Exam> Exams { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<SubOrder> SubOrders { get; set; }
        public DbSet<RolePermissionConnection> RolePermissionConnections { get; set; }
        public DbSet<UserScoreExam> UserScoreExams { get; set; }
        public DbSet<Permission> Permissions { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<User> Users { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var cascadeFKs = modelBuilder.Model.GetEntityTypes()
        .SelectMany(t => t.GetForeignKeys())
        .Where(fk => !fk.IsOwnership && fk.DeleteBehavior == DeleteBehavior.Cascade);
            foreach (var fk in cascadeFKs)
                fk.DeleteBehavior = DeleteBehavior.Restrict;
            modelBuilder.Entity<Role>().HasData(
                new Role() { RoleId = 1, RoleTitle = "Admin" },
                new Role() { RoleId = 2, RoleTitle = "Student" }
                );


            modelBuilder.Entity<Entities.User.User>().HasData(
             new Entities.User.User()
             {
                 UserId = 1,
                 UserAvatar = "Defult.jpg",
                 UserName = "MiladDarabzadeh",
                 UserEmail = "Milad.tutor@gmail.com",
                 UserPhoneNumber = "09139279581",
                 UserRegisterDate = DateTime.Now,
                 UserActiveCodeForEmail = "0569d3e33ac94bcc8c5ee4f93320db45",
                 UserActiveCodeForPhoneNumber = "0569d3e33ac94bcc8c5ee4f93320db45",
                 UserPassword = "62-D5-ED-C9-B0-AD-74-B5-AE-96-2E-5F-7F-C7-91-51",
                 IsActived = true,
                 RoleId = 1,
                 UserNandF = "Milad Darabzadeh"
             },
             new Entities.User.User()
             {
                 UserId = 2,
                 UserName = "AliBarzegar",
                 UserEmail = "alibarzegar013@gmail.com",
                 UserPhoneNumber = "09397894663",
                 UserRegisterDate = DateTime.Now,
                 UserAvatar = "cc4129b2b7db4c1ea499fa5a6208df5d.jpg",
                 UserActiveCodeForEmail = "c53eac7994034d13a36e475e1e00fcac",
                 UserActiveCodeForPhoneNumber = "c53eac7994034d13a36e475e1e00fcac",
                 UserPassword = "0C-0B-33-26-C9-5A-66-D7-37-7A-0A-2F-75-DA-AC-34",
                 IsActived = true,
                 RoleId = 1,
                 UserNandF = "Ali Barzegar"
             }
             );
        }
    }
}
