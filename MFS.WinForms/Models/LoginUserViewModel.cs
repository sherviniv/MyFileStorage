using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MFS.WinForms.Models
{
    [Serializable]
    public class LoginUserViewModel
    {
        public string Username { get; set; }
        public string Password { get; set; }

        protected LoginUserViewModel()
        {
        }

        public LoginUserViewModel(string username,string password)
        {
            (Username, Password) = (username, password);
        }
    }
}
