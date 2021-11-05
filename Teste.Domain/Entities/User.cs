using System;
using System.Collections.Generic;
using System.Text;
using Teste.Domain.Abstractions;
using Teste.Domain.Enums;

namespace Teste.Domain.Entities
{
    public class User : BaseEntity
    {
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Email { get; set; }
        public DateTime DataNascimento { get; set; }
        public Escolaridade Escolaridade { get; set; }
    }
}
