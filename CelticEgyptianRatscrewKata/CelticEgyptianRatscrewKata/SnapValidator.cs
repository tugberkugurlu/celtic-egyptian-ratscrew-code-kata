using System.Collections.Generic;
using System.Linq;

namespace CelticEgyptianRatscrewKata
{
    public class SnapValidator
    {
        public bool CanSnap(Stack stack, List<IRule> rules)
        {
            return rules.Any(rule => rule.CanSnap(stack));
        }
    }
}