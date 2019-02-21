using EventQueue.Common.Models.Enums;
using System.Collections.Generic;

namespace EventQueue.Common.Models
{
    public class EventResult
    {
        public EventResultState ResultState { get; set; }

        public IDictionary<string, string> Messages { get; set; }

        public object ReturnData { get; set; }
    }
}
