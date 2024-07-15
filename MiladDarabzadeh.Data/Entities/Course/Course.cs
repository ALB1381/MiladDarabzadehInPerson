using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Azure.Core.HttpHeader;

namespace MiladDarabzadeh.Data.Entities.Course
{
    public class Course
    {
        [Key]
        public int CourseId { get; set; }

        public string CourseName { get; set; }

        public string CourseDescription { get; set; }

        public string CourseTags { get; set; }

        public string CourseUrl { get; set; }

        public DateTime FirstTimeMadeDate { get; set; }

        public string NamesOfTheBooks { get; set; }


        //Course Prices
        //Time Course
        //Time of Each session
        //Teacher Name
        //Cycles
       
    }
}
