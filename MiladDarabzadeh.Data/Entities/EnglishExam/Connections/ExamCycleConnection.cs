using MiladDarabzadeh.Data.Entities.Course;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiladDarabzadeh.Data.Entities.EnglishExam.Connections
{
    public class ExamCycleConnection
    {
        [Key]
        public int ECCId { get; set; }

        public int ExamId { get; set; }

        public int CycleId { get; set; }

        [ForeignKey("ExamId")]
        public Exam Exam { get; set; }

        [ForeignKey("CycleId")]
        public CourseCycle CourseCycle { get; set; }
    }
}
