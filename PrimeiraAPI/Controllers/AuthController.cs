﻿using Microsoft.AspNetCore.Mvc;
using PrimeiraAPI.Services;
using PrimeiraAPI.Model;

namespace PrimeiraAPI.Controllers
{
    [ApiController]
    [Route("api/v1/auth")]
    public class AuthController : Controller
    {
        [HttpPost]
        public IActionResult Auth(string username, string password) 
        {
            if (username == "Gabriel" && password == "123456") 
            {
                var token = TokenService.GenerateToken(new Employee());
                return Ok(token);
            }

            return BadRequest("username or password invalid");
        }
    }
}
