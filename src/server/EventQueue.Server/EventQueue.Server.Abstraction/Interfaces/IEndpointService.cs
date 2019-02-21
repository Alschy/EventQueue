using EventQueue.Common.Models;
using EventQueue.Common.Models.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace EventQueue.Server.Abstraction.Interfaces
{
    public interface IEndpointService
    {
        EventResult AddReciver(string name, Uri baseUri);

        EventResult ChangeUri(string reciverId, Uri newUri);

        EventResult RemoveReciver(string reciverId);

        EventResult AddEndpoint(string name, IEnumerable<Operations> supportedOpperations, Uri endpointUri);

        EventResult RemoveEndpoint(string endpointId);

        Uri GetAbsolutEndpointUri(string endpointId);

        EventResult SendToEndpoint(string endpointId, object data, Operations operation);
    }
}
