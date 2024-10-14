namespace Noei.BPMS.Domain
{
    public class Activity : BPMNElement
    {
        public Action ActionToExecute { get; set; }

        public Activity(string id, string name, Action action)
            : base(id, name)
        {
            ActionToExecute = action;
        }

        // Activities have work to perform, so they retain the Execute method
        public void Execute()
        {
            Console.WriteLine($"Executing activity: {Name}");
            ActionToExecute?.Invoke();
        }
    }
}
