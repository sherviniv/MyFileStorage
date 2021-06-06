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
    public class StorageFileRepository : IStorageFileRepository
    {
        public List<StorageFile> Get(Expression<Func<StorageFile, bool>> where = null)
        {
            using (var context = new MFSDbContext())
            {
                var query = where != null ?
                    context.Set<StorageFile>().Where(where) : context.Set<StorageFile>();
                return query.ToList();
            }
        }
        
        public StorageFile GetById(int id)
        {
            using (var context = new MFSDbContext())
            {
                return context.StorageFiles.FirstOrDefault(c => c.ID == id);
            }
        }

        public int Add(StorageFile model)
        {
            using (var context = new MFSDbContext())
            {
                context.StorageFiles.Add(model);
                context.SaveChanges();
                return model.ID;
            }
        }

        public void Update(StorageFile model)
        {
            using (var context = new MFSDbContext())
            {
                var dbModel = context.StorageFiles.FirstOrDefault(c => c.ID == model.ID);
                context.Entry(dbModel).CurrentValues.SetValues(model);
                context.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            using (var context = new MFSDbContext())
            {
                var dbModel = context.StorageFiles.FirstOrDefault(c => c.ID == id);
                context.StorageFiles.Remove(dbModel);
                context.SaveChanges();
            }
        }
    }
}
