using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MFS.Persistence.Models
{
    public class FilePermission
    {
        public int ID { get; set; }

        [ForeignKey("User")]
        [Required]
        public int UserID { get; set; }
        public virtual User User { get; set; }

        [ForeignKey("StorageFile")]
        [Required]
        public int StorageFileID { get; set; }
        public virtual StorageFile StorageFile { get; set; }

        public PermissionTypes PermissionType { get; set; }
    }

    public enum PermissionTypes
    {
        Read = 0,
        Modify = 1,
    }
}
