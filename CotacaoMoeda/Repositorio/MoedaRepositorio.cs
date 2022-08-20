using System.Collections.Generic;
using System.Linq;
using CotacaoMoeda.Context;
using CotacaoMoeda.Entidades;
using CotacaoMoeda.Repositorio.Interface;

namespace CotacaoMoeda.Repositorio
{
    public class MoedaRepositorio: IMoedaRepositorio
    {
        private readonly MoneyContext _context;
        public MoedaRepositorio(MoneyContext context)
        {
            _context = context; 
        }
    

        public bool SalvarMoeda(Moeda moeda)
        {
            try
            {
                if (moeda.Id == 0)
                    _context.Moedas.Add(moeda);
                else
                    _context.Moedas.Update(moeda);
                _context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public List<Moeda> BuscarMoedas()
        {
            return _context.Moedas.ToList();
        }
    }
}
