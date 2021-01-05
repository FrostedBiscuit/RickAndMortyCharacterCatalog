using CharacterCatalog.Core.Collections;
using CharacterCatalog.Core.Models;
using System;
using System.Linq;
using System.Collections.Generic;

namespace CharacterCatalog.Core.Helpers
{
    public static class GenericCollectionHelper
    {
        private static Random random = new Random();

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

        public static GenericCollection<TItem> ScrambleWordList<TItem>(this GenericCollection<TItem> collection)
        {
            var selectedWords = collection.Where(w => random.Next(0, 2) == 0).ToArray();
            var initialSize = collection.Count;

            collection.Clear();

            for (int i = 0; i < initialSize; i++)
            {
                var selectedIndex = random.Next(0, selectedWords.Length);

                collection.Add(selectedWords[selectedIndex]);
            }

            return collection;
        }

        public static GenericCollection<TItem> GetUniqueCollection<TItem>(this GenericCollection<TItem> collection)
        {
            var result = new GenericCollection<TItem>();
            var history = new List<TItem>();

            foreach (var item in collection)
            {
                if (!history.Contains(item))
                {
                    result.Add(item);
                    history.Add(item);
                }
            }

            return result;
        }

        public static HashSet<TItem> ToHashSet<TItem>(this GenericCollection<TItem> source)
        {
            return new HashSet<TItem>(source);
        }
    }
}
