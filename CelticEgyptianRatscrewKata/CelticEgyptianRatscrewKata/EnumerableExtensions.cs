using System;
using System.Collections.Generic;
using System.Linq;

namespace CelticEgyptianRatscrewKata
{
    public static class EnumerableExtensions
    {
        public static void Zip<T1, T2>(this IEnumerable<T1> first, IEnumerable<T2> second, Action<T1, T2> action)
        {
            first.Zip(second, (t1, t2) =>
            {
                action(t1, t2);
                return false;
            });
        }
    }
}
