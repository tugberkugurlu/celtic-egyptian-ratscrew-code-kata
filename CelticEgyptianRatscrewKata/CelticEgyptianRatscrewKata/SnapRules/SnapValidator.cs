using System.Collections.Generic;
using System.Linq;

namespace CelticEgyptianRatscrewKata.SnapRules
{
    public class SnapValidator
    {
        public bool CanSnap(Stack stack, IEnumerable<IRule> rules)
        {
            return rules.Any(rule => rule.CanSnap(stack));
        }
    }
}