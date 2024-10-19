namespace Noei.BPMS.Domain
{
    public class WorkflowBootstrapData
    {
        public int WorkflowId { get; set; }

        public Dictionary<string, string> InitialData { get; set; }
    }
}
