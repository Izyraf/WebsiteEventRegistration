using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebsiteEventRegistration.Shared.Domain
{
    public class Register : BaseDomainModel
    {
        public int? EventName { get; set; }
        public virtual Event Event { get; set; }

        public int? UserName { get; set; }
        public virtual User User { get; set; }
    }
}
