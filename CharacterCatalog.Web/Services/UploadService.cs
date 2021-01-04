using CharacterCatalog.Core.Models;
using CharacterCatalog.Core.Services.Interfaces;
using CharacterCatalog.Web.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CharacterCatalog.Web.Services
{
    public class UploadService : IUploadService
    {
        private ICharacterService _characterService;

        public UploadService(ICharacterService characterService)
        {
            _characterService = characterService;
        }

        public async Task<bool> ParseDataFromFile(IFormFile file)
        {
            try 
            {
                using (var stream = new MemoryStream())
                {
                    await file.CopyToAsync(stream);

                    var dataInBytes = stream.ToArray();
                    var decodoedData = Encoding.Default.GetString(dataInBytes);
                    var parsedData = JsonConvert.DeserializeObject<Character[]>(decodoedData);

                    foreach (var character in parsedData)
                    {
                        await _characterService.CreateAsync(character);
                    }

                    return true;
                }
            }
            catch
            {
                return false;
            }
        }
    }
}
