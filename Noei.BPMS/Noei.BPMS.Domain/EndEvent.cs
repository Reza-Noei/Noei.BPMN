namespace Noei.BPMS.Domain
{
    public class EndEvent : BPMNElement
    {
        public EndEvent(string id, string name)
            : base(id, name)
        {
        }

        public void End()
        {
            Console.WriteLine($"Ending event: {Name}");
        }
    }
}
