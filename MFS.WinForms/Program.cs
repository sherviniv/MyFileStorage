using MFS.Persistence.Repository;
using MFS.WinForms.Forms;
using MFS.WinForms.Presenters;
using MFS.WinForms.Views;
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

            //Register Form
            var registerView = new RegisterForm();
            var registerPresenter = new RegisterPresenter(registerView, userRepository);

            //Login Form
            var loginView = new LoginForm(registerView);
            var loginPresenter = new LoginPresenter(loginView, userRepository);
            registerView.LoginForm = loginView;

            //Storage View
            var storageView = new StorageView();
            var storagePresenter = new StoragePresenter(storageView, storageFileRepository);

            //MainForm
            var mainForm = new MainForm(storageView);
            loginView.MainView = mainForm;

            Application.Run(loginView);
        }
    }
}
