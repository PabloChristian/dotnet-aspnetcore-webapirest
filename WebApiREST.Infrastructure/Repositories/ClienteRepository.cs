using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiREST.Domain.Entities;
using WebApiREST.Domain.Interfaces;
using WebApiREST.Infrastructure.Interfaces;

namespace WebApiREST.Infrastructure.Repositories
{
    public class ClienteRepository : IClienteRepository
    {
        protected static IEnumerable<Cliente> listaClientes = new List<Cliente>();
        public IEnumerable<Cliente> RetornarListaClientes()
        {
            return listaClientes;
        }
        public IEnumerable<Cliente> RetornarListaClientes(long _id)
        {
            return listaClientes.Where(m => m.Id == _id).ToList();
        }

        public void Dispose()
        {
            
        }
    }
}
