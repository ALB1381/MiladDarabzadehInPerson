using MiladDarabzadeh.Data.Entities.Course;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiladDarabzadeh.Data.Entities.Order
{
    public class SubOrder
    {
        [Key]
        public int SubOrderId { get; set; }
        public int CyclePrice { get; set; }

        #region Connection Ids
        public int CycleId { get; set; }    
        public int OrderId { get; set; }
        public int? DiscountId { get; set; }
        #endregion

        #region Connections
        [ForeignKey("OrderId")]
        public Order Order { get; set; }

        [ForeignKey("CycleId")]
        public CourseCycle CourseCycle { get; set; }

        [ForeignKey("DiscountId")]
        public Discount.CourseDiscount? CourseDiscount { get; set; }
        #endregion


    }
}
