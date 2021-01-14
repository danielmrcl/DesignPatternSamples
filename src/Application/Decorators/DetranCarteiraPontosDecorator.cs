using DesignPatternSamples.Application.DTO;
using DesignPatternSamples.Application.Services;
using Microsoft.Extensions.Caching.Distributed;
using System.Collections.Generic;
using System.Threading.Tasks;
using Workbench.IDistributedCache.Extensions;

namespace DesignPatternSamples.Application.Decorators
{
    public class DetranCarteiraPontosDecorator : IDetranCarteiraPontosService
    {
        private readonly DetranCarteiraPontosDecorator _Inner;
        private readonly IDistributedCache _Cache;

        public DetranCarteiraPontosDecorator(
            DetranCarteiraPontosDecorator inner,
            IDistributedCache cache)
        {
            _Inner = inner;
            _Cache = cache;
        }

        public Task<IEnumerable<CarteiraPontos>> ConsultarPontos(Carteira carteira)
        {
            return Task.FromResult(_Cache.GetOrCreate($"{carteira.UF}_{carteira.Numero}", () => _Inner.ConsultarPontos(carteira).Result));
        }
    }
} 