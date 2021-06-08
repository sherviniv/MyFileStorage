using MFS.WinForms.Models;
using MFS.WinForms.Presenters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MFS.WinForms.Interfaces
{
    public interface IManageView
    {
        ManagePresenter Presenter { get; set; }
        List<FilePermissionViewModel> FPList { get; set; }
    }
}
