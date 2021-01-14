using DesignPatternSamples.Application.DTO;
using DesignPatternSamples.Application.Repository;
using DesignPatternSamples.Application.Services;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DesignPatternSamples.Application.Implementations
{
    public class DetranPontosCarteiraServices : IDetranCarteiraPontosService
    {
        private readonly IDetranCarteiraPontosFactory _Factory;

        public DetranPontosCarteiraServices(IDetranCarteiraPontosFactory factory)
        {
            _Factory = factory;
        }

        public Task<IEnumerable<CarteiraPontos>> ConsultarPontos(Carteira carteira)
        {
            IDetranCarteiraPontosRepository repository = _Factory.Create(carteira.UF);
            return repository.ConsultarPontos(carteira);
        }
    }
} 