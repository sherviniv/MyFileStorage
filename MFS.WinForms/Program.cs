using MFS.Persistence.Repository;
using MFS.WinForms.Forms;
using MFS.WinForms.Presenters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MFS.WinForms
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //Repositories
            var userRepository = new UserRepository();
            var filePermissionRepository = new FilePermissionRepository();
            var storageFileRepository = new StorageFileRepository();

            //Login Form
            var loginView = new LoginForm();
            var loginPresenter = new LoginPresenter(loginView, userRepository);

            Application.Run(loginView);
        }
    }
}
