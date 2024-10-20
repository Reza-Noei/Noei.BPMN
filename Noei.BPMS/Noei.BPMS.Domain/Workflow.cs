namespace Noei.BPMS.Domain
{
    public class Workflow
    { 
        public ICollection<BPMNElement> Elements { get; private set; }

        public Workflow()
        {
            Elements = new List<BPMNElement>();
        }

        public void AddElement(BPMNElement element)
        {
            Elements.Add(element);
        }

        public void ExecuteWorkflow()
        {
            foreach (var element in Elements)
            {
                if (element is Activity activity)
                {
                    activity.Execute();
                }
                else if (element is Gateway gateway)
                {
                    string flowName = gateway.EvaluateConditions();
                    Console.WriteLine($"Taking flow: {flowName}");
                }
                else if (element is StartEvent startEvent)
                {
                    startEvent.Start();
                }
                else if (element is EndEvent endEvent)
                {
                    endEvent.End();
                }
            }
        }
    }
}
