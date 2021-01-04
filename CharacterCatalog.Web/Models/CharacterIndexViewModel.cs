using CharacterCatalog.Core.Models;
using System.Collections.Generic;

namespace CharacterCatalog.Web.Models
{
    public class CharacterIndexViewModel
    {
        public IEnumerable<Character> Characters { get; set; }
        public int NextPage { get; set; }
        public int LastPage { get; set; }
    }
}
