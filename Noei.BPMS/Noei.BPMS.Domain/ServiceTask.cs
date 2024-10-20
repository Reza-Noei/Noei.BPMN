namespace Noei.BPMS.Domain
{
    public class ServiceTask : BPMNElement
    {
        public ServiceTask(string name) : base(name)
        {

        }

        public string ServiceEndpoint { get; set; }

        public void Execute(WorkflowContext context, IStateStore stateStore)
        {
            Console.WriteLine($"Calling Service Task: {Name} at {ServiceEndpoint}");
            // Logic to perform API call and handle response
        }
    }
}
