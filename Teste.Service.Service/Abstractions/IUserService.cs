using System;
using System.Collections.Generic;
using System.Text;
using Teste.Application.DTOs;
namespace Teste.Service.Service
{
    public interface IUserService
    {
        ContractResult Create(CreateUserRequest request);
        ContractResult Update(UpdateUserRequest request);
        ContractResult Delete(DeleteUserRequest request);
        ContractResult GetAll();
        ContractResult GetById(GetUserByIdRequest request);

    }
}
