using System.Linq.Expressions;

namespace Noei.BPMS.Domain
{
    public class Gateway : BPMNElement
    {
        private Dictionary<string, Expression<Func<bool>>> _conditionalFlows;

        public Gateway(string id, string name)
            : base(id, name)
        {
            _conditionalFlows = new Dictionary<string, Expression<Func<bool>>>();
        }

        // Add conditional flows
        public void AddConditionalFlow(string flowName, Expression<Func<bool>> condition)
        {
            _conditionalFlows[flowName] = condition;
        }

        // Evaluate conditions to determine which flow to take
        public string EvaluateConditions()
        {
            foreach (var flow in _conditionalFlows)
            {
                if (flow.Value.Compile().Invoke())
                {
                    return flow.Key; // Return the name of the matching flow
                }
            }

            return null; // No conditions matched
        }
    }
}
