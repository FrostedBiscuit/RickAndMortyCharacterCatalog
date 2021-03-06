﻿using CharacterCatalog.Core.Constants;
using CharacterCatalog.Core.Models;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;

namespace CharacterCatalog.Core.Services.Interfaces
{
    public interface ICharacterService
    {
        Task<List<Character>> GetAsync();
        Task<List<Character>> GetAsync(int page = CharacterCatalogConsts.Pagination.InitialPage, int pageSize = CharacterCatalogConsts.Pagination.DefaultPageSize);
        Task<Character> GetByIdAsync(int id);
        Task CreateAsync(Character character);
        Task<bool> UpdateAsync(Character character);
        Task RemoveByIdAsync(int id);
        Task<(Dictionary<string, object>, Dictionary<string, DataTable>)> GetQueriesAsync();
    }
}
