using MiladDarabzadeh.Data.Entities.Course.Connections;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiladDarabzadeh.Data.Entities.Course
{
    public class CourseModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column(TypeName = "TINYINT")]
        public int CourseModelId { get; set; }

        [Display(Name = "سبک برگذاری دوره")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MinLength(4, ErrorMessage = "{0} نمیتواند کمتر از {1} کارکتر باشد")]
        [MaxLength(60, ErrorMessage = "{0} نمیتواند بیشتر از {1} کارکتر باشد")]
        [Column(TypeName = "nvarchar(60)")]
        public string ModelTitle { get; set; }

        public List<CourseModelConnection> CourseModelConnections { get; set; }
    }
}
