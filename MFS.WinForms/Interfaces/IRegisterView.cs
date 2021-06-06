using MFS.WinForms.Presenters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MFS.WinForms.Interfaces
{
    public interface IRegisterView
    {
        RegisterPresenter Presenter { get; set; }
        string Username { get; set; }
        string FullName { get; set; }
        string Password { get; set; }
        string RePassword { get; set; }
        string Email { get; set; }
        string Message { get; set; }
    }
}
