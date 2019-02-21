using System;
using System.Collections.Generic;
using System.Text;

namespace EventQueue.Server.Common.Models
{
    public class EventReciver
    {
        public string ReciverId { get; set; }

        public string ReciverName { get; set; }

        public Uri BaseUri { get; set; }

        public IEnumerable<EventReciverEndpoint> EndPoints { get; set; }
    }
}
