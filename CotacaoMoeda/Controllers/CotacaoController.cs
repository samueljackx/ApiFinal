using System;
using System.Collections.Generic;
using CotacaoMoeda.Entidades;
using CotacaoMoeda.Repositorio.Interface;
using Microsoft.AspNetCore.Mvc;

namespace CotacaoMoeda.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class CotacaoController  : Controller
        
    {
        private readonly ICotacaoRepositorio _cotacaoRepositorio;

        public CotacaoController(ICotacaoRepositorio moedaRepositorio)
        {
            _cotacaoRepositorio = moedaRepositorio;
        }

        [HttpPost]
        [Route("SalvarCotacao")]
        public bool SalvarCotacao([FromBody] Cotacao cotacao)
        {
            try
            {
                return _cotacaoRepositorio.SalvarCotacao(cotacao);
            }
            catch
            {
                return false;
            }
        }

        [HttpGet]
        [Route("BuscarCotacao")]
        public Cotacao BuscarCotacao(Moeda moeda, DateTime data)
        {
            return _cotacaoRepositorio.BuscarCotacao(moeda, data);
        }

    }
}
