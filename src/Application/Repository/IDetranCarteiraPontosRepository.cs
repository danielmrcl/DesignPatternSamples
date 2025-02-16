using DesignPatternSamples.Application.DTO;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DesignPatternSamples.Application.Repository
{
    public interface IDetranCarteiraPontosRepository
    {
        Task<IEnumerable<CarteiraPontos>> ConsultarPontos(Carteira carteira);
    }
}