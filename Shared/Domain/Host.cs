using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebsiteEventRegistration.Shared.Domain
{
     public class Host : BaseDomainModel
    {
        public string HostName { get; set; }
        public string HostEmail { get; set; }
    }
}
