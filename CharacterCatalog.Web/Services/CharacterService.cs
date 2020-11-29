using CharacterCatalog.Core.Models;
using CharacterCatalog.Web.Models;
using CharacterCatalog.Web.Services.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace CharacterCatalog.Web.Services
{
    public class CharacterService : ICharacterService
    {
        private readonly CharacterDbContext _context;
 
        public CharacterService(CharacterDbContext context)
        {
            _context = context;
        }

        public Task CreateAsync(Character character)
        {
            _context.Add(character);

            return _context.SaveChangesAsync();
        }

        public Task<List<Character>> GetAsync()
        {
            return _context.Character.ToListAsync();
        }

        public Task<List<Character>> GetAsync(int page = 0, int pageSize = 20)
        {
            return _context.Character.Skip(page * pageSize).Take(pageSize).ToListAsync();
        }
        
        public Task<Character> GetByIdAsync(int id)
        {
            return _context.Character.FirstOrDefaultAsync(m => m.CharacterId == id);
        }

        public async Task RemoveByIdAsync(int id)
        {
            var character = await GetByIdAsync(id);
            _context.Character.Remove(character);
            await _context.SaveChangesAsync();
        }

        public async Task<bool> UpdateAsync(Character character)
        {
            var currCharacter = await GetByIdAsync(character.CharacterId);

            if (currCharacter == null)
            {
                return false;
            }

            currCharacter.Update(character);

            _context.Update(currCharacter);
            await _context.SaveChangesAsync();

            return true;
        }
    }
}
