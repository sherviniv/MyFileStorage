using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MFS.Persistence.Models
{
    public class StorageFile
    {
        public int ID { get; set; }

        [Required]
        [StringLength(maximumLength: 255)]
        public string FileName { get; set; }

        [Required]
        public string FileType { get; set; }

        [ForeignKey("User")]
        public int? UserID { get; set; }
        public virtual User User { get; set; }

        public long FileSize { get; set; }
        public byte[] FileContent { get; set; }

        [Required]
        public DateTime CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }

        public bool IsPublic { get; set; }
    }
}
