using Core.DataAccess;
using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using Umbraco.Core.Persistence.Repositories;

namespace DataAccess.Abstract
{
    public interface IUserDal : IEntityRepos<User>
    {
        List<OperationClaim> GetClaims(User user);
    }
}
