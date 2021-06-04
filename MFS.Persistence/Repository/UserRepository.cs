using MFS.Persistence.Context;
using MFS.Persistence.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MFS.Persistence.Repository
{
    public class UserRepository : IUserRepository
    {

        public List<User> Get(Expression<Func<User, bool>> where = null)
        {
            using (var context = new MFSDbContext())
            {
                var query = where != null ? 
                    context.Set<User>().Where(where) : context.Set<User>();
                return query.ToList();
            }
        }

        public User GetById(int id) 
        {
            using (var context = new MFSDbContext())
            {
                return context.Users.FirstOrDefault(c => c.ID == id);
            }
        }

        public int Add(User model)
        {
            using (var context = new MFSDbContext())
            {
                context.Users.Add(model);
                context.SaveChanges();
                return model.ID;
            }
        }

        public void Update(User model)
        {
            using (var context = new MFSDbContext())
            {
                var dbModel = context.Users.FirstOrDefault(c => c.ID == model.ID);
                context.Entry(dbModel).CurrentValues.SetValues(model);
                context.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            using (var context = new MFSDbContext())
            {
                var dbModel = context.Users.FirstOrDefault(c => c.ID == id);
                context.Users.Remove(dbModel);
                context.SaveChanges();
            }
        }

    }
}
