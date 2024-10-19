namespace Noei.BPMS.Domain
{
    public class WorkflowState
    {
        public string ElementName { get; set; }

        public Dictionary<string, string> StateData { get; set; } = new Dictionary<string, string>();

        public DateTime Timestamp { get; set; } = DateTime.UtcNow; // Automatically record when the state was saved
    }
}
