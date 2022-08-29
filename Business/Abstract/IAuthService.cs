using System;
using Core.Utilities.Results;
using Core.Utilities.Security.JWT;
using Entities.Concrete;
using Entities.DTO;

namespace Business.Abstract
{
    public interface IAuthService
    {
        IDataResult<User> Register(UserForRegisterDTO userForRegisterDTO,string password);
        IDataResult<User> Login(UserForLoginDTO userForLoginDTO);

        IResult UserExist(string mail);
        IDataResult<AccessToken> CreateAccessToken(User user);
    }
}

