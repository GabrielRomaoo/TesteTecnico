using System;
using System.Collections.Generic;
using System.Text;
using Teste.Domain.Entities;

namespace Teste.Application.DTOs
{
    public class GetAllUsersResponse
    {
        IEnumerable<UserDTO> Users { get; set; }
    
    }
}
