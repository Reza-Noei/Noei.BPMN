namespace Noei.BPMS.Domain
{
    public class SequenceFlow
    {
        public BPMNElement Source { get; set; }
        public BPMNElement Target { get; set; }

        public void Trigger()
        {
            Console.WriteLine($"Flow from {Source.Name} to {Target.Name}");
        }
    }
}
