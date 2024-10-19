namespace Noei.BPMS.Domain
{
    public interface IStateStore
    {
        WorkflowState GetState(int workflowId, string elementName);

        void SetState(int workflowId, WorkflowState state);
    }
}
