namespace Noei.BPMS.Domain
{
    public class EndEvent : BPMNElement
    {
        public override void Execute()
        {
            Console.WriteLine("End Event: " + Name);
            // Logic to complete the workflow
        }
    }
}
