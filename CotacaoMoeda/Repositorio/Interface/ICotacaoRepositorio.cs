using System;
using CotacaoMoeda.Entidades;

namespace CotacaoMoeda.Repositorio.Interface
{
    public interface ICotacaoRepositorio
    {
        bool SalvarCotacao(Cotacao cotacao);
        Cotacao BuscarCotacao(Moeda moeda, DateTime data);
    }
}
