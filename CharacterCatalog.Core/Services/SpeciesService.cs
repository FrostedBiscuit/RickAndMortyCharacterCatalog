using CharacterCatalog.Core.Models;
using CharacterCatalog.Core.Services.Interfaces;
using System.Threading.Tasks;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace CharacterCatalog.Core.Services
{
    public class SpeciesService : ISpeciesService
    {
        private readonly CharacterDbContext _context;

        public SpeciesService(CharacterDbContext context)
        {
            _context = context;
        }

        public Task<List<Species>> GetAsync()
        {
            return _context.Species.ToListAsync();
        }

        public Task<Species> GetByIdAsync(int id)
        {
            return _context.Species.FirstOrDefaultAsync(s => s.SpeciesId == id);
        }

        public Task<bool> SpeciesExists(int id)
        {
            return _context.Species.AnyAsync(s => s.SpeciesId == id);
        }
    }
}
