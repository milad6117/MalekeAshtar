using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MalekeAshtar.Domain.Common
{
    public class BaseRelation : IDateEntity
    {
        [Display(Name = "تاریخ ایجاد")]
        [Column(TypeName = "date")]
        public DateTime CreatedAt { get; set; }

        [Display(Name = "تاریخ بروز رسانی")]
        [Column(TypeName = "date")]
        public DateTime? UpdatedAt { get; set; }

        [Display(Name = "تاریخ حذف ")]
        [Column(TypeName = "date")]
        public DateTime? DeletedAt { get; set; }

        [Display(Name = "وضعیت حذف")]
        public bool IsDeleted { get; set; } = false;
    }
}
