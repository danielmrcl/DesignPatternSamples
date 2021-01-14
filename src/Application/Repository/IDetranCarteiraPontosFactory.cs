using System;

namespace DesignPatternSamples.Application.Repository
{
    public interface IDetranCarteiraPontosFactory
    {
        public IDetranCarteiraPontosFactory Register(string UF, Type repository);
        public IDetranCarteiraPontosRepository Create(string UF);
    }
} 