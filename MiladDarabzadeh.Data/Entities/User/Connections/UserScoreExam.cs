using MiladDarabzadeh.Data.Entities.EnglishExam;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiladDarabzadeh.Data.Entities.User.Connections
{
    public class UserScoreExam
    {
        [Key]
        public int USEId { get; set; }

        ///||\\\
       /// ._.\\\
        [Column(TypeName = "TINYINT")]
        public int Score { get; set; }
        public DateTime ExamDate { get; set; }

        public int UserId { get; set; }

        public int ExamId { get; set; }

        [ForeignKey("ExamId")]
        public Exam Exam { get; set; }

        [ForeignKey("UserId")]
        public User User { get; set; }

     
    }
}
