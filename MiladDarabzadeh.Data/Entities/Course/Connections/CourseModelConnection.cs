using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiladDarabzadeh.Data.Entities.Course.Connections
{
    public class CourseModelConnection
    {
        public int CMCId { get; set; }

        public int CourseId { get; set; }

        public int ModelId { get; set; }

        public Course Course { get; set; }

        public CourseModel CourseModel { get; set; }
    }
}
