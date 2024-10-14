namespace Noei.BPMS.Domain
{
    public class StartEvent : BPMNElement
    {
        public override void Execute()
        {
            Console.WriteLine("Start Event: " + Name);
            // Additional logic to trigger the workflow start.
        }
    }
}
