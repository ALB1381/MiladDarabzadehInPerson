using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiladDarabzadeh.Data.Entities.Discount
{
    public class CourseDiscount
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int DiscountId { get; set; }

        [Display(Name = "عنوان تخفیف")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(30, ErrorMessage = "{0} نمیتواند بیشتر از {1} کارکتر باشد")]
        [MinLength(4, ErrorMessage = "{0} نمیتواند کمتر از {1} کارکتر باشد")]
        [Column(TypeName = "nvarchar(30)")]
        public string DiscountTitle { get; set; }

        [Column(TypeName = "TINYINT")]
        public int DisocuntPercentage { get; set; }

        public DateOnly StartDate { get; set; }
        public DateOnly EndDate { get; set; }

        public List<Course.Course> Courses { get; set; }
    }
}
