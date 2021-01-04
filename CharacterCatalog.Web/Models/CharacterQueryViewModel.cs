using CharacterCatalog.Core.Models;
using System.Collections.Generic;
using System.Data;

namespace CharacterCatalog.Web.Models
{
    public class CharacterQueryViewModel
    {
        private Dictionary<string, object> _scalarQueries;

        public Dictionary<string, object> ScalarQueries
        {
            get
            {
                return _scalarQueries;
            }
            set
            {
                _scalarQueries = value;
            }
        }

        private Dictionary<string, DataTable> _entityQueries;

        public Dictionary<string, DataTable> EntityQueries
        {
            get
            {
                return _entityQueries;
            }
            set
            {
                _entityQueries = value;
            }
        }

        public CharacterQueryViewModel()
        {
            ScalarQueries = new Dictionary<string, object>();
            EntityQueries = new Dictionary<string, DataTable>();
        }
    }
}
