﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Teste.Application.DTOs
{
    public class UserDTO
    {
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Email { get; set; }
        public DateTime DataNascimento { get; set; }
        public Escolaridade Escolaridade { get; set; }

    }
}
