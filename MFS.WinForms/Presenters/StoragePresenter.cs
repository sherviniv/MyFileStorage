using MFS.Core.Services;
using MFS.Persistence.Models;
using MFS.Persistence.Repository;
using MFS.WinForms.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MFS.WinForms.Presenters
{
    public class StoragePresenter
    {
        private readonly IStorageView _view;
        private readonly StorageFileRepository _repository;
        private readonly FilePermissionRepository _filePermissionRepository;

        public StoragePresenter(
            IStorageView view,
            StorageFileRepository repository,
            FilePermissionRepository filePermissionRepository)
        {
            _repository = repository;
            _filePermissionRepository = filePermissionRepository;
            _view = view;
            _view.Presenter = this;
        }

        public void UploadFile(string fileName, string filePath, bool isPublic)
        {
            if (File.Exists(filePath))
            {
                var fileInfo = new System.IO.FileInfo(filePath);
                var model = new StorageFile();
                model.CreateDate = DateTime.Now;
                model.FileName = fileName;
                model.UserID = CurrentUserService.UserId;
                model.IsPublic = isPublic;
                model.FileType = fileInfo.Extension;
                model.FileSize = fileInfo.Length;
                using (FileStream file = new FileStream(filePath, FileMode.Open, FileAccess.Read))
                {
                    model.FileContent = new byte[file.Length];
                    file.Read(model.FileContent, 0, (int)file.Length);
                }
                _repository.Add(model);
            }
        }

        public void GetPublicFiles()
        {
            _view.FilesList = _repository.Get(c => c.IsPublic);
        }

        public void GetSharedFiles()
        {
            var fileIds = _filePermissionRepository
                .Get(c => c.UserID == CurrentUserService.UserId)
                .Select(c => c.StorageFileID);
            _view.FilesList = _repository.Get(c => fileIds.Contains(c.ID));
        }

        public void GetCurrentUserFiles()
        {
            _view.FilesList = _repository.Get(c => c.UserID == CurrentUserService.UserId);
        }

        public void RemoveFile(int fileId) 
        {
            _repository.Delete(fileId);
        }
    }
}
