using MFS.Persistence.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MFS.Persistence.Repository
{
    public interface IStorageFileRepository
    {
        List<StorageFile> Get(Expression<Func<StorageFile, bool>> where = null);
        StorageFile GetById(int id);
        int Add(StorageFile model);
        void Update(StorageFile model);
        void Delete(int id);
    }
}
