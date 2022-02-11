using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebsiteEventRegistration.Client.Static
{
    public class Endpoints
    {
        private static readonly string Prefix = "api";

        public static readonly string EventEndpoint = $"{Prefix}/events";
        public static readonly string HostEndpoint = $"{Prefix}/hosts";
        public static readonly string UserEndpoint = $"{Prefix}/users";
        public static readonly string RegisterEndpoint = $"{Prefix}/registers";

    }
}
