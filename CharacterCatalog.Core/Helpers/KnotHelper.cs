using CharacterCatalog.Core.Collections;
using CharacterCatalog.Core.Models;
using System;
using System.Collections.Generic;

namespace CharacterCatalog.Core.Helpers
{
    public static class KnotHelper
    {
        public static GenericCollection<Character> FilterForHumans(this Knot<Character> knot)
        {
            var result = new GenericCollection<Character>();
            var currentKnot = knot.Start;

            while (currentKnot.Next != null)
            {
                if (currentKnot.Data.Species.SpeciesId == 1)
                {
                    result.Add(currentKnot.Data);
                }

                currentKnot = currentKnot.Next;
            }

            return result;
        }

        public static TItem LongestToString<TItem>(this Knot<TItem> source)
        {
            var current = source.Start;
            var result = current.Data;

            while (current != null)
            {
                if (current.ToString().Length > result.ToString().Length)
                {
                    result = current.Data;
                }

                current = current.Next;
            }

            return result;
        }

        public static Knot<TItem> GetUnique<TItem>(this Knot<TItem> source)
        {
            var result = new Knot<TItem>();

            var current = source.Start;
            var history = new List<TItem>();

            while (current != null)
            {
                if (!history.Contains(current.Data))
                {
                    result.Add(current.Data);
                    history.Add(current.Data);
                }

                current = current.Next;
            }

            return result.Count() > 0 ? result : null;
        }
    }
}
