using System;
using System.Linq;
using CotacaoMoeda.Context;
using CotacaoMoeda.Entidades;
using CotacaoMoeda.Repositorio.Interface;
using Microsoft.AspNetCore.Components;
using Microsoft.EntityFrameworkCore;

namespace CotacaoMoeda.Repositorio
{
    
    [Route("[Controller]")]
    public class CotacaoRepositorio : ICotacaoRepositorio
    {
        private readonly MoneyContext _context;
        public CotacaoRepositorio(MoneyContext context)
        {
            _context = context;
        }

        public bool SalvarCotacao(Cotacao cotacao)
        {
            try
            {
                if (cotacao.Id == 0)
                    _context.Cotacao.Add(cotacao);
                else
                    _context.Cotacao.Update(cotacao);
                _context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public Cotacao BuscarCotacao(Moeda moeda, DateTime data)
        {
            return _context.Cotacao.Include(c => c.Moeda).Where(c => c.Moeda == moeda && c.Data == data).FirstOrDefault();
        }
    }
}
