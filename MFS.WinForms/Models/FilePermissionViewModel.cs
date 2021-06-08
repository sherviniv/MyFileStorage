using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MFS.WinForms.Models
{
    public class FilePermissionViewModel
    {
        public int Id { get; set; }

        [DisplayName("Username")]
        public string Username { get; set; }

        [DisplayName("File Name")]
        public string FileName { get; set; }

        [DisplayName("Permission Type")]
        public string PermissionType { get; set; }
    }
}
