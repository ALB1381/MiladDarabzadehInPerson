using Microsoft.EntityFrameworkCore;
using MiladDarabzadeh.Data.Entities.Course;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiladDarabzadeh.Data.Entities.User
{
    public class User
    {
        #region Column
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int UserId { get; set; }

        [Display(Name = "نام کاربری")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(60, ErrorMessage = "{0} نمیتواند بیشتر از {1} کارکتر باشد")]
        [MinLength(4, ErrorMessage = "{0} نمیتواند کمتر از {1} کارکتر باشد")]
        [Column(TypeName = "nvarchar(60)")]
        public string UserName { get; set; }

        [Display(Name = "نام و نام خانوادگی")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(70, ErrorMessage = "{0} نمیتواند بیشتر از {1} کارکتر باشد")]
        [MinLength(4, ErrorMessage = "{0} نمیتواند کمتر از {1} کارکتر باشد")]
        [Column(TypeName = "nvarchar(70)")]
        public string UserNandF { get; set; }

        [Display(Name = "ایمیل")]
        [MaxLength(90, ErrorMessage = "{0} نمیتواند بیشتر از {1} کارکتر باشد")]
        [MinLength(4, ErrorMessage = "{0} نمیتواند کمتر از {1} کارکتر باشد")]
        [Column(TypeName = "nvarchar(90)")]
        public string? UserEmail { get; set; }

        [Display(Name = "شماره تماس")]
        [MaxLength(16, ErrorMessage = "{0} نمیتواند بیشتر از {1} کارکتر باشد")]
        [MinLength(9, ErrorMessage = "{0} نمیتواند کمتر از {1} کارکتر باشد")]
        [Column(TypeName = "nvarchar(16)")]
        public string UserPhoneNumber { get; set; }

        [Display(Name = "تاریخ ثبت نام")]
        public DateTime UserRegisterDate { get; set; } = DateTime.Now;

        [Display(Name = "آواتار")]
        public string UserAvatar { get; set; }

        [Display(Name = "کد فعال سازی ایمیل")]
        [MaxLength(50, ErrorMessage = "{0} نمیتواند بیشتر از {1} کارکتر باشد")]
        [Column(TypeName = "nvarchar(50)")]
        public string? UserActiveCodeForEmail { get; set; }

        [Display(Name = "کد فعال سازی شماره تلقن")]
        [MaxLength(50, ErrorMessage = "{0} نمیتواند بیشتر از {1} کارکتر باشد")]
        [Column(TypeName = "nvarchar(50)")]
        public string UserActiveCodeForPhoneNumber { get; set; }

        [Display(Name = "رمز ورود")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(80, ErrorMessage = "{0} نمیتواند بیشتر از {1} کارکتر باشد")]
        [MinLength(8, ErrorMessage = "{0} نمیتواند کمتر از {1} کارکتر باشد")]
        [Column(TypeName = "nvarchar(80)")]
        public string UserPassword { get; set; }

        public DateOnly? BirthDate { get; set; }

        public bool IsPhoneNumberActived { get; set; }
        public bool IsEmailActived { get; set; }

        #endregion
        
        #region Relation Ids
        public int RoleId { get; set; }
        #endregion

        #region Relation
        [ForeignKey("RoleId")]
        public Role Role { get; set; }

        public List<Course.Course>? TeacherCourses { get; set; }
        #endregion
    }
}
