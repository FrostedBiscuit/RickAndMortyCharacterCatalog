using CharacterCatalog.Core.Models;
using System.Collections.Generic;

namespace CharacterCatalog.Web.Models
{
    public class CharacterViewModel
    {
        private Character _character;
        public Character Character 
        { 
            get
            {
                return _character;
            } 
            set
            {
                _character = value;
            } 
        }

        public int SelectedSpeciesId { get; set; }

        private ICollection<Species> _species;
        public ICollection<Species> Species 
        { 
            get
            {
                return _species;
            } 
            set
            {
                _species = value;
            }
        }
    }
}
