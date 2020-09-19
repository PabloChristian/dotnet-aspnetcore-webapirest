using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiREST.Domain.Entities;

namespace WebApiREST.Domain.Interfaces
{
    interface IClienteService : IDisposable
    {
        public IEnumerable<Cliente> RetornarClientes();
        public IEnumerable<Cliente> RetornarClientes(long _id);
    }
}
