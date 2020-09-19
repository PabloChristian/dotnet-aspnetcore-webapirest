using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiREST.Domain.Entities;

namespace WebApiREST.Infrastructure.Interfaces
{
    public interface IClienteRepository
    {
        public IEnumerable<Cliente> RetornarListaClientes();
        public IEnumerable<Cliente> RetornarListaClientes(long _id);
        void Dispose();
    }
}
