using System;
using Core.Entities;

namespace Entities.DTO
{
    public class UserForLoginDTO : IDto
    {
        public string Email { get; set; }
        public string Password { get; set; }
    }
}

