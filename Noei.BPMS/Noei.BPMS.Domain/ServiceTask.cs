namespace Noei.BPMS.Domain
{
    public class ServiceTask : BPMNElement
    {
        public string ServiceEndpoint { get; set; }

        public override void Execute()
        {
            Console.WriteLine($"Calling Service Task: {Name} at {ServiceEndpoint}");
            // Logic to perform API call and handle response
        }
    }
}
