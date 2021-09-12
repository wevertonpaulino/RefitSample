using Refit;
using System.Threading.Tasks;

namespace RefitSample
{
    public interface IApiService
    {
        [Get("/ws/{cep}/json")]
        Task<ApiResponse> GetAsync(string cep);
    }
}
