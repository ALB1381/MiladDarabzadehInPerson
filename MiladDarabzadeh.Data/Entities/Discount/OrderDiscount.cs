using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiladDarabzadeh.Data.Entities.Discount
{
    public class OrderDiscount
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int OrderDiscounId { get; set; }


        [Display(Name = "کد تخفیف")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(60, ErrorMessage = "{0} نمیتواند بیشتر از {1} کارکتر باشد")]
        [MinLength(4, ErrorMessage = "{0} نمیتواند کمتر از {1} کارکتر باشد")]
        [Column(TypeName = "nvarchar(60)")]
        public string DiscountCode { get; set; }

        public int? Price { get; set; }


        public int? AvaibleCount { get; set; }
        //
        [Column(TypeName = "TINYINT")]
        public int? Percentage { get; set; }

        public int? PriceLimite { get; set; }

        public DateOnly StartDate { get; set; }

        public DateOnly EndDate { get; set; }


    }
}
