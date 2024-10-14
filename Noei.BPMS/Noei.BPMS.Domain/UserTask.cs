namespace Noei.BPMS.Domain
{
    public class UserTask : BPMNElement
    {
        public string Assignee { get; set; }

        public override void Execute()
        {
            Console.WriteLine($"User Task '{Name}' assigned to: {Assignee}");
            // Logic for assigning the task and waiting for completion
        }

        public void Complete()
        {
            Console.WriteLine($"User Task '{Name}' completed by: {Assignee}");
            // Move to the next step in the workflow
        }
    }
}
