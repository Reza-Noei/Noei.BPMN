namespace Noei.BPMS.Domain
{
    public class StartEvent : BPMNElement
    {
        public StartEvent(string name)
            : base(name)
        {
        }

        public void Start()
        {
            Console.WriteLine($"Starting event: {Name}");
        }
    }
}
