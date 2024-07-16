using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Azure.Core.HttpHeader;

namespace MiladDarabzadeh.Data.Entities.Course
{
    public class Course
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CourseId { get; set; }

        [Display(Name = "نام دوره")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(20, ErrorMessage = "{0} نمیتواند بیشتر از {1} کارکتر باشد")]
        [MinLength(4, ErrorMessage = "{0} نمیتواند کمتر از {1} کارکتر باشد")]
        [Column(TypeName = "nvarchar(20)")]
        public string CourseName { get; set; }

        [Display(Name = "توضیحات دوره")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MinLength(4, ErrorMessage = "{0} نمیتواند کمتر از {1} کارکتر باشد")]
        public string CourseDescription { get; set; }

        [Display(Name = "تگ ها")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MinLength(4, ErrorMessage = "{0} نمیتواند کمتر از {1} کارکتر باشد")]
        [MaxLength(60, ErrorMessage = "{0} نمیتواند بیشتر از {1} کارکتر باشد")]
        [Column(TypeName = "nvarchar(60)")]
        public string CourseTags { get; set; }
        
        [Display(Name = "آدرس کوتاه صفحه")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MinLength(4, ErrorMessage = "{0} نمیتواند کمتر از {1} کارکتر باشد")]
        [MaxLength(60, ErrorMessage = "{0} نمیتواند بیشتر از {1} کارکتر باشد")]
        [Column(TypeName = "nvarchar(60)")]
        public string CourseUrl { get; set; }


        public DateTime FirstTimeMadeDate { get; set; }

        
        [Display(Name = "نام کتاب های این دوره")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MinLength(4, ErrorMessage = "{0} نمیتواند کمتر از {1} کارکتر باشد")]
        [MaxLength(70, ErrorMessage = "{0} نمیتواند بیشتر از {1} کارکتر باشد")]
        [Column(TypeName = "nvarchar(70)")]
        public string NamesOfTheBooks { get; set; }

        [Column(TypeName = "TINYINT")]
        public int? MinAge { get; set; }
        [Column(TypeName = "TINYINT")]
        public int? MaxAge { get; set; }

        [Display(Name = "رنج نمره آیلتس برای در این دوره")]
        public int? RangeOfIELTSInThisCourse { get; set; }

        [Display(Name = " رنج نمره شنیداری در این دوره")]
        public int? RangeOfListeningInThisCourse { get; set; }

        [Display(Name = "رنج نمره نوشتاری در این دوره")]
        public int? RangeOfWritingInThisCourse { get; set; }

        [Display(Name = "رنج نمره خواندن در این دوره")]
        public int? RangeOfReadingInThisCourse { get; set; }

        [Display(Name = "رنج نمره صحبت کردن در این دوره")]
        public int? RangeOfSpeakingInThisCourse { get; set; }

        [MinLength(170)]
        [MaxLength(250)]
        [Display(Name = "توضیحات کوتاه")]
        [Required]
        public string ShortDescription { get; set; }

        [Display(Name = "دوره قابلیت پرداخت قسطی دارد")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        public bool LoanPayments { get; set; }

        [Display(Name = "مدرک")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        public bool Certificate { get; set; }

        public string CourseImage { get; set; }

        [MaxLength(100, ErrorMessage = "{0} نمیتواند بیشتر از {1} کارکتر باشد")]
        public string? DemoFileName { get; set; }
        //Course Prices
        //Time Course
        //Time of Each session
        //Teacher Name
        //Cycles
        //Types Course

        [Required]
        public int GroupId { get; set; }

        public int SubGroupId { get; set; }

        public int? DiscountId { get; set; }

        public int TeacherId { get; set; }

        [Required]
        public int StatusId { get; set; }

        [Required]
        public int LevelId { get; set; }

        [Display(Name = "دوره مکمل")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        public int? SupplementId { get; set; }

        [Display(Name = "آزمون")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        public int? TestId { get; set; }
    }
}
