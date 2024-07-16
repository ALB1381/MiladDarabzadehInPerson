using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiladDarabzadeh.Data.Entities.Course
{
    public class CourseLevel
    {
        [Key]
        [Column(TypeName = "TINYINT")]
        public int LevelId { get; set; }


        [Display(Name = "عنوان سطح")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(40, ErrorMessage = "{0} نمیتواند بیشتر از {1} کارکتر باشد")]
        [MinLength(4, ErrorMessage = "{0} نمیتواند کمتر از {1} کارکتر باشد")]
        [Column(TypeName = "nvarchar(40)")]
        public string LevelTitle { get; set; }

        public List<Course> Courses { get; set; }
    }
}
