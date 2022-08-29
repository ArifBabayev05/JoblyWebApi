using System;
using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using Core.Utilities.Security.Hashing;
using Core.Utilities.Security.JWT;
using Entities.Concrete;
using Entities.DTO;

namespace Business.Concrete
{
    public class AuthManager : IAuthService
    {
        private IUserService _userService;
        private ITokenHelper _tokenHelper;

        public AuthManager(IUserService userService, ITokenHelper tokenHelper)
        {
            _userService = userService;
            _tokenHelper = tokenHelper;
        }

        public IDataResult<AccessToken> CreateAccessToken(User user)
        {
            var claims = _userService.GetClaims(user);
            _tokenHelper.CreateToken(user, claims);
            return new SuccessDataResult<AccessToken>(Messages.AccessTokenCreated);
        }

        public IDataResult<User> Login(UserForLoginDTO userForLoginDTO)
        {
            var userToCheck = _userService.GetByEmail(userForLoginDTO.Email);
            if(userToCheck == null)
            {
                return new ErrorDataResult<User>(Messages.UserNotFound);
            }
            if (!HashingHelper.VerifyPasswordHash(userForLoginDTO.Password,userToCheck.PasswordHash,userToCheck.PasswordSalt))
            {
                return new ErrorDataResult<User>(Messages.PasswordError);
            }

            return new SuccessDataResult<User>(userToCheck,Messages.SuccessfulLogin);
        }

        public IDataResult<User> Register(UserForRegisterDTO userForRegisterDTO, string password)
        {
            byte[] passwordSalt;
            byte[] passwordHash;
            //HashingHelper.CreatePasswordHash(password,out passwordHash, out passwordSalt);
            HashingHelper.CreatePasswordHash(password,out passwordHash, out passwordSalt);
            var user = new User
            {
                Email = userForRegisterDTO.Email,
                FirstName = userForRegisterDTO.Firstname,
                LastName = userForRegisterDTO.Lastname,
                PasswordHash = passwordHash,
                PasswordSalt = passwordSalt,
                Status = true
                
            };
            _userService.Add(user);
            return new SuccessDataResult<User>(Messages.UserRegistered);

        }

        public IResult UserExist(string mail)
        {
            if (_userService.GetByEmail(mail) != null)
            {
                return new ErrorResult(Messages.UserAlreadyExist);
            }
            return new SuccessResult();
        }
    }
}

