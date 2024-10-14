namespace Noei.BPMS.Domain
{
    public class Workflow
    {
        private List<BPMNElement> _elements;

        public Workflow()
        {
            _elements = new List<BPMNElement>();
        }

        // Add BPMN elements (Activity, Gateway, Event, etc.)
        public void AddElement(BPMNElement element)
        {
            _elements.Add(element);
        }

        public void ExecuteWorkflow()
        {
            // Iterate through the elements and execute them as needed
            foreach (var element in _elements)
            {
                if (element is Activity activity)
                {
                    activity.Execute();  // Execute activities
                }
                else if (element is Gateway gateway)
                {
                    string flowName = gateway.EvaluateConditions();  // Evaluate conditions in gateway
                    Console.WriteLine($"Taking flow: {flowName}");
                    // Based on flowName, you could add logic to move to a specific element.
                }
                else if (element is StartEvent startEvent)
                {
                    startEvent.Start();  // Handle Start event
                }
                else if (element is EndEvent endEvent)
                {
                    endEvent.End();  // Handle End event
                }
            }
        }
    }
}
