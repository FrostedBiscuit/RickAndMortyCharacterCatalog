using Newtonsoft.Json;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CharacterCatalog.Core.Models
{
    public class Species
    {
        private int _speciesId;
        [JsonProperty("id")]
        [Key]
        public int SpeciesId
        {
            get
            {
                return _speciesId;
            }
            set
            {
                _speciesId = value;
            }
        }

        private string _name;
        [JsonProperty("name")]
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }

        private ICollection<Character> _characters;
        public ICollection<Character> Characters
        {
            get
            {
                return _characters;
            }
            set
            {
                _characters = value;
            }
        } 

        public Species()
        {
            SpeciesId = -1;
            Name = "";
        }

        public override bool Equals(object obj)
        {
            return SpeciesId == ((Species)obj).SpeciesId;
        }

        public override int GetHashCode()
        {
            return SpeciesId.GetHashCode();
        }

        public override string ToString()
        {
            return Name;
        }

        public static bool operator ==(Species s1, Species s2)
        {
            return s1.SpeciesId == s2.SpeciesId;
        }

        public static bool operator !=(Species s1, Species s2)
        {

            return s1.SpeciesId != s2.SpeciesId;
        }
    }
}
