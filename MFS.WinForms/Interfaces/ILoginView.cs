using MFS.WinForms.Presenters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MFS.WinForms.Interfaces
{
    public interface ILoginView
    {
        LoginPresenter Presenter { get; set; }
        string Username { get; set; }
        string Password { get; set; }
        string Message { get; set; }
        bool RememberMe { get; set; }
    }
}
