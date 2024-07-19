using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiladDarabzadeh.Data.Entities.Course
{
    public class CourseCycle
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CycleId { get; set; }

        [Display(Name = "عنوان گروه جلسات")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(40, ErrorMessage = "{0} نمیتواند بیشتر از {1} کارکتر باشد")]
        [MinLength(4, ErrorMessage = "{0} نمیتواند کمتر از {1} کارکتر باشد")]
        [Column(TypeName = "nvarchar(40)")]
        public string CycleTitle { get; set; }

        public DateOnly StartDate { get; set; }
        
        public DateOnly EndDate { get; set; }

        public int CourseId { get; set; }

        [Column(TypeName = "TINYINT")]
        public int NumberOfSessions { get; set; }

        public int CycleModelId { get; set; }

        [ForeignKey("CourseId")]
        public Course Course { get; set; }

        [ForeignKey("CycleModel")]
        public CycleModel CycleModel { get; set; }


        public List<SubCycle> SubCycles { get; set; }


    }
}
