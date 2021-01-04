using CharacterCatalog.Core.Models;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace CharacterCatalog.Core.Services.Interfaces
{
    public interface ISpeciesService
    {
        Task<List<Species>> GetAsync();
        Task<Species> GetByIdAsync(int id);
        Task<bool> SpeciesExists(int id);
    }
}
