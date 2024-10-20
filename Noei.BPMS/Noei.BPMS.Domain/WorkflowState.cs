namespace Noei.BPMS.Domain
{
    public class WorkflowState
    {
        public string CurrentElement { get; private set; }

        public Dictionary<string, string> StateData { get; private set; } = new Dictionary<string, string>();

        public DateTime Timestamp { get; private set; } = DateTime.UtcNow;
    }
}
