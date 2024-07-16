using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiladDarabzadeh.Data.Entities.Course
{
    public class CourseGroup
    {
        [Key]
        public int GroupId { get; set; }


        [Display(Name = "عنوان گروه")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(50, ErrorMessage = "{0} نمیتواند بیشتر از {1} کارکتر باشد")]
        [MinLength(4, ErrorMessage = "{0} نمیتواند کمتر از {1} کارکتر باشد")]
        [Column(TypeName = "nvarchar(50)")]
        public string GroupTitle { get; set; }
        //note

        [Display(Name = "گروه اصلی")]
        public int? ParentId { get; set; }

        [ForeignKey("ParentId")]
        public List<CourseGroup> courseGroups { get; set; }


        [InverseProperty("CourseGroup")]
        public List<Course> GroupOfCourses { get; set; }

        [InverseProperty("CourseSubGroup")]
        public List<Course>? SubGroupsOfCourse { get; set; }

    }
}
