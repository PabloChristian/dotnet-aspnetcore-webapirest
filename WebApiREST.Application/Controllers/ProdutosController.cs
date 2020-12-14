using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WebApiREST.Domain.Entities;
using WebApiREST.Domain.Interfaces;
using WebApiREST.Domain.Services;
using WebApiREST.Infrastructure.Repositories;

namespace WebApiREST.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProdutosController : ControllerBase
    {
        private readonly ILogger<ProdutosController> _logger;
        private readonly IProdutoService _ProdutoService;
        private readonly ProdutoRepository _ProdutoRepository;
        public ProdutosController(ILogger<ProdutosController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<Produto> Get()
        {
            IEnumerable<Produto> listaProdutos = new List<Produto>();

            ProdutoService produto = new ProdutoService(_ProdutoRepository);
            listaProdutos = produto.RetornarProdutos();
            produto.Dispose();
            return listaProdutos;
        }

        [HttpGet]
        public IEnumerable<Produto> Get(long _SKU)
        {
            IEnumerable<Produto> listaProdutos = new List<Produto>();
            IProdutoService produto = new ProdutoService(_ProdutoRepository);
            listaProdutos = produto.RetornarProdutos(_SKU);
            produto.Dispose();
            return listaProdutos;
        }
    }
}
