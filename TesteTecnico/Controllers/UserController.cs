using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Teste.Application.DTOs;
using Teste.Domain.Entities;
using Teste.Service.Service;
namespace TesteTecnico.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private IUserService _service;

        public UserController(IUserService userService)
        {
            _service = userService;
        }
        
        [HttpPost]
        public IActionResult Create([FromBody] CreateUserRequest request)
        {
            if (request == null)
                return NotFound();

            var result = _service.Create(request);

            if (result.Valid)
            {
                return Ok(result);
            }
            else
            {
                return BadRequest(result);
            }
        }

        [HttpPost]
        public IActionResult Delete ([FromBody] DeleteUserRequest request)
        {
            if (request == null)
                return NotFound();

            var result = _service.Delete(request);

            if (result.Valid)
            {
                return Ok(result);
            }
            else
            {
                return BadRequest(result);
            }
        }

        [HttpPost]
        public IActionResult Update([FromBody] UpdateUserRequest request)
        {
            if (request == null)
                return NotFound();

            var result = _service.Update(request);

            if (result.Valid)
            {
                return Ok(result);
            }
            else
            {
                return BadRequest(result);
            }
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            
            var result = _service.GetAll();

            if (result.Valid)
            {
                return Ok(result);
            }
            else
            {
                return BadRequest(result);
            }
        }

        [HttpGet]
        public IActionResult GetById(GetUserByIdRequest request)
        {

            var result = _service.GetById(request);

            if (result.Valid)
            {
                return Ok(result);
            }
            else
            {
                return BadRequest(result);
            }
        }

    }
}
