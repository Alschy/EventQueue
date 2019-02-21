using System;
using System.Collections.Generic;
using System.Text;

namespace EventQueue.Server.Common.Models
{
    public class RootEvent
    {
        public string Id { get; set; }

        public EventDescriptor EventDescription { get; set; }

        public EventData EventData { get; set; }
    }
}
