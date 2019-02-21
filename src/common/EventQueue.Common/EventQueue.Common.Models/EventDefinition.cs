using EventQueue.Common.Models.Enums;
using System.Collections.Generic;

namespace EventQueue.Common.Models
{
    public class EventDefinition
    {
        public string EventKey { get; set; }

        public IEnumerable<Operations>  SupportedOperations { get; set; }

        public IEnumerable<EventDefinitionEndpoint> EndpointSubscriptions { get; set; }
    }
}
