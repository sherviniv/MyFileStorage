using MFS.WinForms.Presenters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MFS.WinForms.Interfaces
{
    public interface IStorageView
    {
        StoragePresenter Presenter { get; set; }
    }
}
