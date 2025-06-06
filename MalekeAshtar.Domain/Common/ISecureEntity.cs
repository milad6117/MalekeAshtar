using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MalekeAshtar.Domain.Common
{
    public interface ISecureEntity
    {
        public string CreatedByIP { get; set; }
        public string CreateByBrowser { get; set; }
        public string? UpdatedByIP { get; set; }
        public string? UpdatedByBrowser { get; set; }
        public string? DeletedByIP { get; set; }
        public string? DeletedByBrowser { get; set; }

    }
}
