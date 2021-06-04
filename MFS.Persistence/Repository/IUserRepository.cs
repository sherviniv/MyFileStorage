using MFS.Persistence.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MFS.Persistence.Repository
{
    public interface IUserRepository
    {
        List<User> Get(Expression<Func<User, bool>> where = null);
        User GetById(int id);
        int Add(User model);
        void Update(User model);
        void Delete(int id);
    }
}
