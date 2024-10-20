using System.Linq.Expressions;

namespace Noei.BPMS.Domain
{
    public class Gateway : BPMNElement
    {
        public Dictionary<string, Expression<Func<bool>>> ConditionalFlows { get; private set; }

        public Gateway(string name) : base(name)
        {
            ConditionalFlows = new Dictionary<string, Expression<Func<bool>>>();
        }

        public void AddConditionalFlow(string targetElementName, Expression<Func<bool>> condition)
        {
            ConditionalFlows[targetElementName] = condition;
        }

        public string EvaluateConditions()
        {
            foreach (var condition in ConditionalFlows)
            {
                if (condition.Value.Compile().Invoke())
                {
                    return condition.Key;
                }
            }

            return null; 
        }
    }


}
