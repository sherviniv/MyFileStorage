using MFS.Persistence.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MFS.Persistence.Context
{
    public class MFSDbContext : DbContext
    {
        public MFSDbContext() : base("name=MFSContextConnectionString")
        {

        }

        public DbSet<User> Users { get; set; }
        public DbSet<StorageFile> StorageFiles { get; set; }
        public DbSet<FilePermission> FilePermissions { get; set; }

    }
}
