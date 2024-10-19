namespace Noei.BPMS.Domain
{
    public class WorkflowContext
    {
        public int WorkflowId { get; set; } 

        public WorkflowState CurrentState { get; set; }

        public WorkflowBootstrapData BootstrapData { get; set; }
    }
}
