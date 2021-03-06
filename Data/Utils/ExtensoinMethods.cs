﻿using System.Collections.Generic;

namespace Data.Utils
{
    public static class ExtensoinMethods
    {
        public static HashSet<T> ToHashSet<T>(this IEnumerable<T> source, IEqualityComparer<T> comparer = null)
        {
            return  new HashSet<T>(source, comparer);
        }
    }
}
