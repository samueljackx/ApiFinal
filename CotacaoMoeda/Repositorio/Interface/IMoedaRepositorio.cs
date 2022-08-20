using System.Collections.Generic;
using CotacaoMoeda.Entidades;

namespace CotacaoMoeda.Repositorio.Interface
{
    public interface IMoedaRepositorio
    {
        bool SalvarMoeda(Moeda moeda);
        List<Moeda> BuscarMoedas();
    }
}
