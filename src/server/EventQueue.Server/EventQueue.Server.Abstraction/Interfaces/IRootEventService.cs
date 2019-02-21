using EventQueue.Common.Models;
using EventQueue.Common.Models.Enums;
using System;

namespace EventQueue.Server.Abstraction.Interfaces
{
    public interface IRootEventService
    {
        EventResult CreateEvent(string eventKey, object eventData, string eventDataIdentifiere, string eventSource, Operations operation ,TimeSpan eventDelay);

        EventResult GetCurrentState(string eventId);

        EventResult CancelEvent(string eventId);

        EventResult UpdateEvent(string eventId, object newEventData);

        EventResult FindEvent(string eventDataIdentifiere);

        EventResult FindEvent(string eventDataIdentifiere, string eventKey);
    }
}
