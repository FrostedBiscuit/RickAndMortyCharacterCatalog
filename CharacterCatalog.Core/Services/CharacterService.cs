using CharacterCatalog.Core.Models;
using CharacterCatalog.Core.Services.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;

using static CharacterCatalog.Core.Constants.CharacterCatalogConsts;

namespace CharacterCatalog.Core.Services
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
            return _context.Character.Include(c => c.Species).ToListAsync();
        }

        public Task<List<Character>> GetAsync(int page = 0, int pageSize = 20)
        {
            return _context.Character.Include(c => c.Species).Skip(page * pageSize).Take(pageSize).ToListAsync();
        }

        public Task<Character> GetByIdAsync(int id)
        {
            return _context.Character.Include(c => c.Species).FirstOrDefaultAsync(m => m.CharacterId == id);
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


        public async Task<(Dictionary<string, object>, Dictionary<string, DataTable>)> GetQueriesAsync()
        {
            var result = (new Dictionary<string, object>(), new Dictionary<string, DataTable>());

            // Scalar queries

            result.Item1.Add(
                SQLQueries.CharacterCount,
                await _context.ExecuteScalarAsync(SQLQueries.CharacterCount));

            result.Item1.Add(
                SQLQueries.CharactersWithUndefinedTypesCount,
                await _context.ExecuteScalarAsync(SQLQueries.CharactersWithUndefinedTypesCount));

            result.Item1.Add(
                SQLQueries.MostCommonStatus,
                (Status)(int)(long)await _context.ExecuteScalarAsync(SQLQueries.MostCommonStatus));

            // "Entity" queries

            result.Item2.Add(
                SQLQueries.StatusStatistics,
                await _context.ExecuteTableAsync(SQLQueries.StatusStatistics));

            result.Item2.Add(
                SQLQueries.UniqueTypes,
                await _context.ExecuteTableAsync(SQLQueries.UniqueTypes));

            result.Item2.Add(
                SQLQueries.DifferentSpeciesAndTheirOccurrences,
                await _context.ExecuteTableAsync(SQLQueries.DifferentSpeciesAndTheirOccurrences));

            return result;
        }
    }
}
