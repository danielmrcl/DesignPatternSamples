using System;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;
using DesignPatternSamples.Application.DTO;
using System.Collections.Generic;

namespace DesignPatternSamples.Infra.Repository.Detran
{
    public class DetranMGVerificadorDebitosRepository : DetranVerificadorDebitosRepositoryCrawlerBase
    {
        private readonly ILogger _Logger;

        public DetranMGVerificadorDebitosRepository(ILogger<DetranMGVerificadorDebitosRepository> logger)
        {
            _Logger = logger;
        }

        protected override Task<IEnumerable<DebitoVeiculo>> PadronizarResultado(string html)
        {
            _Logger.LogDebug($"Padronizando o Resultado {html}.");
            return Task.FromResult<IEnumerable<DebitoVeiculo>>(new List<DebitoVeiculo>() { new DebitoVeiculo() });
        }

        protected override Task<string> RealizarAcesso(Veiculo veiculo)
        {
            _Logger.LogDebug($"Consultando débitos do veículo placa {veiculo.Placa} para o estado de MG.");
            return Task.FromResult("CONTEUDO DO SITE DO DETRAN/MG");
        }
    }
}