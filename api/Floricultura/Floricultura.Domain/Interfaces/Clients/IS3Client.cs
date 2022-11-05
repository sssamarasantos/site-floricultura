using Microsoft.AspNetCore.Http;

namespace Floricultura.Domain.Interfaces.Clients
{
    public interface IS3Client
    {
        Task UploadFileAsync(string filePath, IFormFile foto);
    }
}
