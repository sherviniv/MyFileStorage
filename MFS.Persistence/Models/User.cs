using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MFS.Persistence.Models
{
    public class User
    {
        public int ID { get; set; }

        [Required]
        [StringLength(maximumLength: 255)]
        public string Username { get; set; }

        [Required]
        [StringLength(maximumLength: 255)]
        public string FullName { get; set; }

        [Required]
        [StringLength(maximumLength: 64,MinimumLength = 64)]
        public string Password { get; set; }

        [Required]
        [EmailAddress]
        [StringLength(maximumLength: 255)]
        public string Email { get; set; }

        public UserTypes UserType { get; set; }
    }

    public enum UserTypes
    {
        [Description("Free Plan")]
        Free = 0,

        [Description("Basic Plan")]
        Basic = 1,

        [Description("Premium Account")]
        Premium = 2,
    }
}
