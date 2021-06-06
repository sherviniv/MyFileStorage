using MFS.Persistence.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MFS.Persistence.Repository
{
    public interface IFilePermissionRepository
    {
        List<FilePermission> Get(Expression<Func<FilePermission, bool>> where = null);
        FilePermission GetById(int id);
        int Add(FilePermission model);
        void Update(FilePermission model);
        void Delete(int id);
    }
}
