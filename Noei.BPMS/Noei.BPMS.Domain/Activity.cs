namespace Noei.BPMS.Domain
{
    public class Activity : BPMNElement
    {
        public Action ActionToExecute { get; set; }

        public Activity(string name, Action action): base(name)
        {
            ActionToExecute = action;
        }

        public void Execute()
        {
            Console.WriteLine($"Executing activity: {Name}");
            ActionToExecute?.Invoke();
        }
    }
}
