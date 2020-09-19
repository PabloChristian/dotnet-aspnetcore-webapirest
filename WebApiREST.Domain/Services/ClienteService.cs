using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiREST.Domain.Entities;
using WebApiREST.Domain.Interfaces;
using WebApiREST.Infrastructure.Interfaces;

namespace WebApiREST.Domain.Services
{
    public class ClienteService : IClienteService
    {
		private readonly IClienteRepository clienteRepository;

		public ClienteService(IClienteRepository _clienteRepository)
		{
			clienteRepository = _clienteRepository;
		}

		public IEnumerable<Cliente> RetornarClientes()
        {
			try
			{
				return clienteRepository.RetornarListaClientes();
			}
			catch (Exception)
			{

				throw;
			}
        }
		public IEnumerable<Cliente> RetornarClientes(long _id)
		{
			try
			{
				return clienteRepository.RetornarListaClientes(_id);
			}
			catch (Exception)
			{

				throw;
			}
		}
		public void Dispose()
		{
			clienteRepository.Dispose();
		}
	}
}
