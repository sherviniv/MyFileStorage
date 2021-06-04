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
    public class FilePermissionRepository : IFilePermissionRepository
    {
        public List<FilePermission> Get(Expression<Func<FilePermission, bool>> where = null)
        {
            using (var context = new MFSDbContext())
            {
                var query = where != null ?
                    context.Set<FilePermission>().Where(where) : context.Set<FilePermission>();
                return query.ToList();
            }
        }

        public FilePermission GetById(int id)
        {
            using (var context = new MFSDbContext())
            {
                return context.FilePermissions.FirstOrDefault(c => c.ID == id);
            }
        }

        public int Add(FilePermission model)
        {
            using (var context = new MFSDbContext())
            {
                context.FilePermissions.Add(model);
                context.SaveChanges();
                return model.ID;
            }
        }

        public void Update(FilePermission model)
        {
            using (var context = new MFSDbContext())
            {
                var dbModel = context.FilePermissions.FirstOrDefault(c => c.ID == model.ID);
                context.Entry(dbModel).CurrentValues.SetValues(model);
                context.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            using (var context = new MFSDbContext())
            {
                var dbModel = context.FilePermissions.FirstOrDefault(c => c.ID == id);
                context.FilePermissions.Remove(dbModel);
                context.SaveChanges();
            }
        }
    }
}
