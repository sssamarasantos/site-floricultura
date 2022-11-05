using Amazon;
using Amazon.S3;
using Amazon.S3.Transfer;
using Floricultura.Domain.Aws;
using Floricultura.Domain.Interfaces.Clients;
using Microsoft.AspNetCore.Http;

namespace Floricultura.Data.Client
{
    public class S3Client : IS3Client
    {
        private readonly IAmazonS3 _client;
        public S3Client()
        {
            _client = new AmazonS3Client(RegionEndpoint.USEast1);
        }

        public async Task UploadFileAsync(string filePath, IFormFile foto)
        {
            try
            {
                using var memoryStream = new MemoryStream();
                foto.CopyTo(memoryStream);
                var request = new TransferUtilityUploadRequest
                {
                    BucketName = GlobalSecrets.Configuracoes.S3BucketFoto,
                    Key = filePath,
                    InputStream = memoryStream
                };

                var fileTransferUtility = new TransferUtility(_client);
                await fileTransferUtility.UploadAsync(request);
            }
            catch (AmazonS3Exception e)
            {
                throw new AmazonS3Exception(e.Message);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
