using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiladDarabzadeh.Data.Entities.Course
{
    public class SubCycle
    {
        [Key]
        public int SubCycleId { get; set; }


        public int SesionID { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public int CourseCycleId { get; set; }

        [ForeignKey("CourseCycleId")]
        public CourseCycle CourseCycle { get; set; }

    }
}
