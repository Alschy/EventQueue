using EventQueue.Common.Models;

namespace EventQueue.Server.Abstraction.Interfaces
{
    public interface IEventDefinitionService
    {
        EventResult WriteDefinition(EventDefinition eventDefinition);

        EventResult RemoveDefinition(string eventKey);

        EventDefinition GetDefinition(string eventKey);
    }
}
