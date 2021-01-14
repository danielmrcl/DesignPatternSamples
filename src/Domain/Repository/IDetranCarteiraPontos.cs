using System.Threading.Tasks;

namespace DesignPatternSamples.Domain.Repository.Detran
{
    public interface IDetranCarteiraPontos
    {
        Task<CarteiraPontos> ConsultarPontos(Carteira carteira);
    }
}