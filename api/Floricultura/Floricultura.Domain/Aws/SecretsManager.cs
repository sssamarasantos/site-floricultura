using Amazon;
using Amazon.SecretsManager;
using Amazon.SecretsManager.Model;
using System.Text;

namespace Floricultura.Domain.Aws
{
    public static class SecretsManager 
    {
        public static async Task<string> GetSecretValueAsync(string secretName)
        {
            try
            {
                var request = new GetSecretValueRequest
                {
                    SecretId = secretName
                };

                using var client = new AmazonSecretsManagerClient(RegionEndpoint.USEast1);

                var response = await client.GetSecretValueAsync(request);

                if (response?.SecretString != null)
                {
                    return response.SecretString;
                }
                else
                {
                    using var reader = new StreamReader(response?.SecretBinary);
                    return Encoding.UTF8.GetString(Convert.FromBase64String(reader.ReadToEnd()));
                }
            }
            catch (ResourceNotFoundException)
            {
                throw new ResourceNotFoundException("Secret" + secretName + "não encontrado!");
            }
            catch (InvalidRequestException e)
            {
                throw new InvalidRequestException(e.Message);
            }
            catch (InvalidParameterException e)
            {
                throw new InvalidParameterException(e.Message);
            }
        }
    }
}
