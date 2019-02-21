using EventQueue.Server.Common.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace EventQueue.Server.Common.Models
{
    public class EventDescriptor
    {
        public string EventName { get; set; }

        public TimeSpan EventDelay { get; set; }

        public DateTimeOffset Created { get; set; }

        public string CreatedFrom { get; set; }

        public DateTimeOffset LastStatusChange { get; set; }

        public EventState EventState { get; set; }
    }
}
