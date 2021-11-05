using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Teste.Application.DTOs;
using Teste.Domain.Abstractions;
using Teste.Domain.Entities;
using Teste.Domain.Validators;


namespace Teste.Service.Service.Service
{
    public class UserService : IUserService
    {

        private readonly IBaseRepository<User> _repository;

        public UserService(IBaseRepository<User> repository )
        {
            _repository = repository;
        }
        public ContractResult Create(CreateUserRequest request)
        {
            try {

                var newUser = new User
                {
                    Nome = request.Nome,
                    Sobrenome = request.Sobrenome,
                    Email = request.Email,
                    DataNascimento = request.DataNascimento,
                    Escolaridade = request.Escolaridade

                };

                UserValidator validator = new UserValidator();

                var result = validator.Validate(newUser);

                if(result.IsValid)
                {
                    _repository.Insert(newUser);
                    return ContractResult.ValidContractResult("Usuário adicionado com sucesso!");
                }
                else
                {
                    return ContractResult.InvalidContractResult(result.ToString(","));
                }
            }
            catch
            {
                return ContractResult.InvalidContractResult("Erro na criação de usuário!");
            }
        }

        public ContractResult Delete(DeleteUserRequest request)
        {
            try
            {
                var user = _repository.GetById(request.Id);

                _repository.Delete(user);

                return ContractResult.ValidContractResult("Usuário excluido com sucesso!");
            }
            catch
            {
                return ContractResult.InvalidContractResult("Erro na exclusão de usuário!");
            }
        }

        public ContractResult GetAll()
        {

            try
            {
                var users = _repository.GetAll();
                                
                return ContractResult.ValidContractResult("Ok!",users);
            }
            catch
            {
                return ContractResult.InvalidContractResult("Erro na consulta de usuários!");
            }
            

        }

        public ContractResult GetById(GetUserByIdRequest request)
        {
            try
            {
                var user = _repository.GetById(request.Id);

                return ContractResult.ValidContractResult("Ok!", user);
            }
            catch
            {
                return ContractResult.InvalidContractResult("Erro na consulta de usuário!");
            }
        }

        public ContractResult Update(UpdateUserRequest request)
        {
            try
            {
                var updatedUser = new User
                {
                    Nome = request.Nome,
                    Sobrenome = request.Sobrenome,
                    Email = request.Email,
                    DataNascimento = request.DataNascimento,
                    Escolaridade = request.Escolaridade

                };
                
                UserValidator validator = new UserValidator();

                var result = validator.Validate(updatedUser);

                if (result.IsValid)
                {
                    _repository.Insert(updatedUser);
                    return ContractResult.ValidContractResult("Usuário editado com sucesso!");
                }
                else
                {
                    return ContractResult.InvalidContractResult(result.ToString(","));
                }
            }
            catch
            {
                return ContractResult.InvalidContractResult("Erro na edição de usuário!");
            }
        }
    }
}
