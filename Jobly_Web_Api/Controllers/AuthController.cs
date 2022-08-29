using System;
using Business.Abstract;
using Entities.DTO;
using Microsoft.AspNetCore.Mvc;

namespace Jobly_Web_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : Controller
    {
        private IAuthService _authService;

        public AuthController(IAuthService authService)
        {
            _authService = authService;
        }

        [HttpPost("login")]
        public IActionResult Login(UserForLoginDTO userForLoginDTO)
        {
            var userToLogin = _authService.Login(userForLoginDTO);
            if (!userToLogin.Success)
            {
                return BadRequest(userToLogin.Messsage);
            }

            var result = _authService.CreateAccessToken(userToLogin.Data);

            if (result.Success)
            {
                return Ok(result.Data);
            }
            else
            {
                return BadRequest(result.Messsage);
            }
        }
        [HttpPost("register")]
        public IActionResult Register(UserForRegisterDTO userForRegisterDTO)
        {
            var userExist = _authService.UserExist(userForRegisterDTO.Email);
            if (!userExist.Success)
            {
                return BadRequest(userExist.Messsage);
            }
            var registeResult = _authService.Register(userForRegisterDTO, userForRegisterDTO.Password);
            var result = _authService.CreateAccessToken(registeResult.Data);
            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result.Messsage);



        }
    }
}

