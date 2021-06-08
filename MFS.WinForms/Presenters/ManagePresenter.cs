using MFS.Core.Services;
using MFS.Persistence.Models;
using MFS.Persistence.Repository;
using MFS.WinForms.Interfaces;
using MFS.WinForms.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MFS.WinForms.Presenters
{
    public class ManagePresenter
    {
        private readonly IManageView _view;
        private readonly IStorageFileRepository _repository;
        private readonly IFilePermissionRepository _filePermissionRepository;
        private readonly IUserRepository _userRepository;

        public ManagePresenter(
            IManageView view,
            IStorageFileRepository repository,
            IFilePermissionRepository filePermissionRepository,
            IUserRepository userRepository)
        {
            _repository = repository;
            _userRepository = userRepository;
            _filePermissionRepository = filePermissionRepository;
            _view = view;
            _view.Presenter = this;
        }

        public void GetGridInfo()
        {
            var currentUserFiles = _repository.Get(c => c.UserID == CurrentUserService.UserId);
            var filesIds = currentUserFiles.Select(c => c.ID);
            var sharedIds = _filePermissionRepository.Get(c => filesIds.Contains(c.StorageFileID));
            _view.FPList = (from file in currentUserFiles
                            join fp in sharedIds on file.ID equals fp.StorageFileID
                            join user in _userRepository.Get() on fp.UserID equals user.ID
                            select new FilePermissionViewModel()
                            {
                                Id = fp.ID,
                                FileName = file.FileName,
                                PermissionType = fp.PermissionType == 0 ? "Read" : "Modify",//TODO:Get desc by reflection
                                Username = user.Username
                            }).ToList();
        }

        public Dictionary<int, string> GetUsers() =>
             _userRepository.Get(c => c.ID != CurrentUserService.UserId)
                            .ToDictionary(k => k.ID, c => c.Username);

        public Dictionary<int, string> GetFiles() =>
              _repository.Get(c => c.UserID == CurrentUserService.UserId)
                         .ToDictionary(k => k.ID, c => c.FileName);

        public Dictionary<int, string> GetPermissionTypes()
        {
            return new Dictionary<int, string>(){
                {0, "Read"},
                {1, "Modify"}
            };
        }

        public void GrantAccess(int userId, int fileId, int permissionType)
        {
            var model = new FilePermission()
            {
                StorageFileID = fileId,
                UserID = userId,
                PermissionType = (PermissionTypes)permissionType
            };
            _filePermissionRepository.Add(model);
        }

        public void RemoveGrant(int id) =>
            _filePermissionRepository.Delete(id);

    }
}
