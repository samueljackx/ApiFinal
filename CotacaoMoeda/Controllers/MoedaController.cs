using System.Collections.Generic;
using CotacaoMoeda.Entidades;
using CotacaoMoeda.Repositorio.Interface;
using Microsoft.AspNetCore.Mvc;

namespace CotacaoMoeda.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class MoedaController : Controller
    {
        private readonly IMoedaRepositorio _moedaRepositorio;

        public MoedaController(IMoedaRepositorio moedaRepositorio)
        {
            _moedaRepositorio = moedaRepositorio;
        }
        [HttpPost]
        [Route("SalvarMoeda")]
        public bool SalvarMoeda([FromBody] Moeda moeda)
        {
            try
            {
                return _moedaRepositorio.SalvarMoeda(moeda);
            }
            catch
            {
                return false;
            }
        }

         [HttpGet]
         [Route("BuscarMoedas")]
         public List<Moeda> BuscarMoedas()
         {
            return _moedaRepositorio.BuscarMoedas();
         }
        }
    }
