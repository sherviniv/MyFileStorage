using MFS.Core.Services;
using MFS.Core.Utilities;
using MFS.Persistence.Repository;
using MFS.WinForms.Interfaces;
using MFS.WinForms.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MFS.WinForms.Presenters
{
    public class LoginPresenter
    {
        private readonly ILoginView _view;
        private readonly IUserRepository _repository;

        public LoginPresenter(
            ILoginView view,
            IUserRepository repository)
        {
            _repository = repository;
            _view = view;
            _view.Presenter = this;
        }

        public bool Authenticate()
        {
            var hashPwd = Encrypt.HashString(_view.Password);
            var user = _repository.Get(
                c => c.Username == _view.Username && hashPwd == c.Password).FirstOrDefault();
            bool succeed = user != null;

            _view.Message = succeed ? string.Empty : "Incorrect username or password";

            if (succeed)
            {
                CurrentUserService.UserId = user.ID;
                CurrentUserService.Username = user.Username;
                SetUserCredentials();
            }

            return succeed;
        }

        public void SetUserCredentials()
        {
            if (_view.RememberMe)
                SaveCredentials(new LoginUserViewModel(_view.Username, _view.Password));
            else
            {
                var path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "usercrd.bin");
                if (File.Exists(path))
                    File.Delete(path);
            }
        }

        public void SaveCredentials(LoginUserViewModel model)
        {
            var path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "usercrd.bin");
            using (Stream stream = File.Open(path, FileMode.Create))
            {
                var binaryFormatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                binaryFormatter.Serialize(stream, model);
            }
        }

        public void ReadCredentials()
        {
            var filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "usercrd.bin");
            if (File.Exists(filePath))
                using (Stream stream = File.Open(filePath, FileMode.Open))
                {
                    var binaryFormatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                    var model = (LoginUserViewModel)binaryFormatter.Deserialize(stream);
                    _view.Username = model.Username;
                    _view.Password = model.Password;
                    _view.RememberMe = true;
                }
        }
    }
}
