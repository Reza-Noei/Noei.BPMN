namespace Noei.BPMS.Domain
{
    public class WorkflowContext
    {
        public Guid Id { get; private set; }

        public virtual Workflow Workflow { get; private set; } 

        public virtual WorkflowState CurrentState { get; private set; }

        public virtual WorkflowBootstrapData BootstrapData { get; private set; }
    }
}
