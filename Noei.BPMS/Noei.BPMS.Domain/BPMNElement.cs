namespace Noei.BPMS.Domain
{
    public abstract class BPMNElement
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public abstract void Execute();
    }
}
