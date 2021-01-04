using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace CharacterCatalog.Web.Services.Interfaces
{
    public interface IUploadService
    {
        Task<bool> ParseDataFromFile(IFormFile file);
    }
}
