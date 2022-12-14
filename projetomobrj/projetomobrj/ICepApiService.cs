using Refit;
using System;
using System.Text;
using System.Threading.Tasks;

namespace projetomobrj
{
    public interface ICepApiService
    {
        [Get("/ws/{cep}/json")]
        Task<CepResponse> GetAddressAsync(string cep);
    }
}
