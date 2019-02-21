namespace EventQueue.Server.Common.Enums
{
    public enum EventState
    {
        New = 1,
        OnProgress = 2,
        Delegated = 3,
        Updated = 4,
        Succsess = 10,
        Warning = 11,
        Error = 12,
        Canceled = 13,
    }
}
