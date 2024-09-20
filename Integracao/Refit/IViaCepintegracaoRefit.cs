using First_API.Integracao.Response;
using Refit;

namespace First_API.Integracao.Refit
{
    public interface IViaCepintegracaoRefit
    {
        [Get("/ws/{cep}/json")]
        Task<ApiResponse<ViaCepResponse>> ObterDadosViaCep(string cep);
    }
}
