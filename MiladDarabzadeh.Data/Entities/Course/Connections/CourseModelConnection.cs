using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiladDarabzadeh.Data.Entities.Course.Connections
{
    public class CourseModelConnection
    {
        [Key]
        public int CMCId { get; set; }

        public int CourseId { get; set; }

        public int ModelId { get; set; }

        [ForeignKey("CourseId")]
        public Course Course { get; set; }

        [ForeignKey("ModelId")]
        public CourseModel CourseModel { get; set; }
    }
}
