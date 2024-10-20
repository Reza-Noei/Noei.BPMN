namespace Noei.BPMS.Domain
{
    public class EndEvent : BPMNElement
    {
        public EndEvent(string name): base(name) { }

        public void End()
        {
            Console.WriteLine($"Ending event: {Name}");
        }
    }
}
