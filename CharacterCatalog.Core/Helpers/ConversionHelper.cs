using CharacterCatalog.Core.Collections;
using System.Collections.Generic;
using System.Linq;

namespace CharacterCatalog.Core.Helpers
{
    public static class ConversionHelper
    {
        public static GenericCollection<T> ToGenericCollection<T>(this IEnumerable<T> source)
        {
            var result = new GenericCollection<T>();

            foreach (var item in source)
            {
                result.Add(item);
            }

            return result;
        }

        public static Knot<T> ToKnot<T>(this IEnumerable<T> source)
        {
            var result = new Knot<T>(source.First());

            foreach (var item in source.Skip(1))
            {
                result.Add(item);
            }

            return result;
        }
    }
}
