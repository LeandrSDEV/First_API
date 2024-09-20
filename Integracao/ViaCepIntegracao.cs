using First_API.Integracao.Interfaces;
using First_API.Integracao.Refit;
using First_API.Integracao.Response;

namespace First_API.Integracao
{
    public class ViaCepIntegracao : IViaCepIntegracao
    {
        private readonly IViaCepintegracaoRefit _viaCepintegracaoRefit;
        public ViaCepIntegracao(IViaCepintegracaoRefit viaCepintegracaoRefit)
        {
            _viaCepintegracaoRefit = viaCepintegracaoRefit;
        }

        public async Task<ViaCepResponse> ObterDadosViaCep(string cep)
        {
           var responseData = await _viaCepintegracaoRefit.ObterDadosViaCep(cep);

            if (responseData != null && responseData.IsSuccessStatusCode)
            {
                return responseData.Content;
            }

            return null;
        }
    }
}
