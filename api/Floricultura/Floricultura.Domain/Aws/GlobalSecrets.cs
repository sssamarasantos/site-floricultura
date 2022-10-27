using Floricultura.Domain.Models.Configuracoes;
using System.Text.Json;

namespace Floricultura.Domain.Aws
{
    public static class GlobalSecrets
    {
        private static Configuracoes? _configuracoes;
        public static Configuracoes Configuracoes
        {
            get
            {
                if (_configuracoes == null)
                {
                    var resultado = SecretsManager.GetSecretValueAsync("SITE-FLORICULTURA").Result;
                    _configuracoes = JsonSerializer.Deserialize<Configuracoes>(resultado);
                }

                return _configuracoes;
            }
        }
    }
}
