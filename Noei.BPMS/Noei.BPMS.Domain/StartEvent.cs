namespace Noei.BPMS.Domain
{
    public class StartEvent : BPMNElement
    {
        public StartEvent(string id, string name)
            : base(id, name)
        {
        }

        public void Start()
        {
            Console.WriteLine($"Starting event: {Name}");
        }
    }
}
