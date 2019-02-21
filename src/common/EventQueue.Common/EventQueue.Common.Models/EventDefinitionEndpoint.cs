using System;
using System.Collections.Generic;

namespace EventQueue.Common.Models
{
    public class EventDefinitionEndpoint
    {
        public Guid EndpointId { get; set; }

        public bool IsRequierd { get; set; }

        public IEnumerable<EventDefinitionEndpoint> PastEndpoints { get; set; }
    }
}
