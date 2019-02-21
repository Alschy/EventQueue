using EventQueue.Common.Models.Enums;
using System;
using System.Collections.Generic;

namespace EventQueue.Server.Common.Models
{
    public class EventReciverEndpoint
    {
        public string EndpointId { get; set; }

        public string EndpointName { get; set; }

        public Uri EndpointUri { get; set; }

        public IEnumerable<Operations> SupportedOperations { get; set; }

    }
}
