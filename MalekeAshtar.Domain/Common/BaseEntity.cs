using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MalekeAshtar.Domain.Common
{
    public abstract class BaseEntity : BaseSecure, IEntity<Guid>, IDateEntity
    {
        public BaseEntity()
        {
            Id = Guid.NewGuid();
        }

        [Required]
        [Display(Name = "شناسه")]
        public Guid Id { get; set; }

        [Display(Name = "تاریخ ایجاد")]
        public DateTime CreatedAt { get; set; }

        [Display(Name = "تاریخ بروز رسانی")]
        public DateTime? UpdatedAt { get; set; }

        [Display(Name = "تاریخ حذف ")]
        public DateTime? DeletedAt { get; set; }

        [Display(Name = "وضعیت حذف")]
        public bool IsDeleted { get; set; } = false;
    }

    public abstract class BaseSecure : ISecureEntity
    {
        public required string CreatedByIP { get; set; }
        public required string CreateByBrowser { get; set; }
        public string? UpdatedByIP { get; set; }
        public string? UpdatedByBrowser { get; set; }
        public string? DeletedByIP { get; set; }
        public string? DeletedByBrowser { get; set; }
    }
}
