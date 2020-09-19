using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WebApiREST.Domain.Entities;
using WebApiREST.Domain.Services;
using WebApiREST.Infrastructure.Repositories;

namespace WebApiREST.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ClientesController : ControllerBase
    {
        private readonly ILogger<ClientesController> _logger;
        private readonly IClienteService _clienteService;
        private readonly ClienteRepository _clienteRepository;
        public ClientesController(ILogger<ClientesController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<Cliente> Get()
        {
            IEnumerable<Cliente> listaClientes = new List<Cliente>();

            listaClientes = 

        }
    }
}
