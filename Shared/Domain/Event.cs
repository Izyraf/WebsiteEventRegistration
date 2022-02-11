using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebsiteEventRegistration.Shared.Domain
{
     public class Event : BaseDomainModel
    {
        public int? HostID { get; set; }
        public virtual Host Host { get; set; } 
        public string EventName { get; set; }
        public DateTime EventDate { get; set; }
        public string EventAddress { get; set; }
        public int EventCapacity { get; set; }
        public string Description { get; set; }
       


    }
}
