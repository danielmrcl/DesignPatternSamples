using DesignPatternSamples.Application.DTO;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DesignPatternSamples.Application.Services
{
    public interface IDetranCarteiraPontosService
    {
        Task<IEnumerable<CarteiraPontos>> ConsultarPontos(Carteira carteira);
    }
}