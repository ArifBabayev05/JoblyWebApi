using System;
using Core.EntityFramework;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Contexts;
using Entities.Concrete;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfUserDal : EfEntityRepositoryBase<User, JoblyContext>, IUserDal
    {
        public void GetClaims(User user)
        {
            using(var context = new JoblyContext())
            {
                //var result = from operationClaim in context.OperationClaims
                //             join UserOperationClaim in context.UserOperationClaims
                //             on operationClaim.Id equals UserOperationClaim.OperationClaimId
                //             where UserOperationClaim.UserId == user.Id
                //             select new OperationClaim { Id = operationClaim.Id, Name = operationClaim.Name };

                //return result.ToList();
                
            }
        }

        List<OperationClaim> IUserDal.GetClaims(User user)
        {
            throw new NotImplementedException();
        }
    }
}

