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

        public StoragePresenter(
            IStorageView view,
            StorageFileRepository repository)
        {
            _repository = repository;
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
    }
}
