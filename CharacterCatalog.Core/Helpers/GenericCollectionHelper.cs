using CharacterCatalog.Core.Collections;
using CharacterCatalog.Core.Models;
using System.Collections.Generic;
using System.Linq;

namespace CharacterCatalog.Core.Helpers
{
    public static class GenericCollectionHelper
    {
        public static GenericCollection<Character> ClassicalQuery(this GenericCollection<Character> collection)
        {
            var result = new GenericCollection<Character>();

            foreach (var character in collection)
            {
                if (character.Species.SpeciesId == 1)
                {
                    result.Add(character);
                }
            }

            return result;
        }

        public static TItem LongestToString<TItem>(this GenericCollection<TItem> collection)
        {
            return collection.Aggregate((i1, i2) => i1.ToString().Length > i2.ToString().Length ? i1 : i2);
        }

        public static HashSet<TItem> ToSet<TItem>(this GenericCollection<TItem> collection)
        {
            return new HashSet<TItem>(collection);
        }
    }
}
