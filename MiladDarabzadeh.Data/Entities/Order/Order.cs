using MiladDarabzadeh.Data.Entities.User;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiladDarabzadeh.Data.Entities.Order
{
    public class Order
    {
        [Key]
        public int OrderId { get; set; }


        public int Sum { get; set; }

        public DateTime CreateDate { get; set; } = DateTime.Now;

        public bool IsFinally { get; set; }


        #region Connection Ids
        public int UserId { get; set; }
        public int? DiscountId { get; set; }
        #endregion

        #region Connections
        [ForeignKey("UserId")]
        public User.User User { get; set; }

        public List<SubOrder> SubOrders { get; set; }

        [ForeignKey("DiscountId")]
        public Discount.OrderDiscount? OrderDiscount { get; set; }
        #endregion

    }
}
