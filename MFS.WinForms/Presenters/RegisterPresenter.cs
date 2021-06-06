using MFS.Core.Utilities;
using MFS.Persistence.Models;
using MFS.Persistence.Repository;
using MFS.WinForms.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MFS.WinForms.Presenters
{
    public class RegisterPresenter
    {
        private readonly IRegisterView _view;
        private readonly IUserRepository _repository;

        public RegisterPresenter(
            IRegisterView view,
            IUserRepository repository)
        {
            _repository = repository;
            _view = view;
            _view.Presenter = this;
        }

        public bool RegisterUser()
        {
            var isValid = IsValid();
            if (isValid)
            {
                var user = new User()
                {
                    Email = _view.Email,
                    FullName = _view.FullName,
                    Password = Encrypt.HashString(_view.Password),
                    Username = _view.Username,
                    UserType = UserTypes.Free
                };
                _repository.Add(user);
            }

            return isValid;
        }

        public bool IsValid()
        {
            if (string.IsNullOrEmpty(_view.Email))
            {
                _view.Message = "Please Enter a valid Email";
                return false;
            }

            if (string.IsNullOrEmpty(_view.Username))
            {
                _view.Message = "Please Enter Username";
                return false;
            }

            if (string.IsNullOrEmpty(_view.FullName))
            {
                _view.Message = "Please Enter Full Name";
                return false;
            }

            if (string.IsNullOrEmpty(_view.Password) || string.IsNullOrEmpty(_view.RePassword))
            {
                _view.Message = "Please Enter Password";
                return false;
            }

            if (_view.Password != _view.RePassword)
            {
                _view.Message = "Your password does not match";
                return false;
            }

            if (_repository.Get(c => c.Username.ToLower() == _view.Username.ToLower()).Any())
            {
                _view.Message = "Username already exists";
                return false;
            }

            return true;
        }

        public void ResetInputs()
        {
            _view.Email = string.Empty;
            _view.Username = string.Empty;
            _view.FullName = string.Empty;
            _view.Password = string.Empty;
            _view.RePassword = string.Empty;
            _view.Message = string.Empty;
        }
    }
}
