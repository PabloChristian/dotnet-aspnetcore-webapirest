using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiREST.Domain.Entities
{
    public class Cliente : Entity
    {
        public long Id { get; private set; }
        private string Nome { get; set; }
        private string CPF { get; set; }
        public Cliente(long _id, string _nome, string _cpf)
        {
            this.Id = _id;
            this.Nome = _nome;
            this.CPF = _cpf;
        }
    }
}
