using MFS.Persistence.Models;
using MFS.WinForms.Components;
using MFS.WinForms.Forms;
using MFS.WinForms.Interfaces;
using MFS.WinForms.Presenters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MFS.WinForms.Views
{
    public partial class StorageView : UserControl, IStorageView
    {
        public StorageView()
        {
            InitializeComponent();
        }

        public StoragePresenter Presenter { get; set; }
        public List<StorageFile> FilesList { get; set; }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            using (var uploadForm = new UploadForm())
            {
                uploadForm.FileSelected += (obj, selectedFile) =>
                {
                    Presenter.UploadFile(selectedFile.fileName, selectedFile.filePath, selectedFile.isPublic);
                };
                uploadForm.ShowDialog();
                btnMyFiles_Click(null, EventArgs.Empty);
            }
        }

        private void btnPublic_Click(object sender, EventArgs e)
        {
            Presenter.GetPublicFiles();
            RenderFilesView(false);
        }

        private void btnMyFiles_Click(object sender, EventArgs e)
        {
            Presenter.GetCurrentUserFiles();
            RenderFilesView(true);
        }

        private void btnShared_Click(object sender, EventArgs e)
        {
            Presenter.GetSharedFiles();
            RenderFilesView(false);
        }

        private void RenderFilesView(bool editMode)
        {
            filesPanel.Controls.Clear();

            filesPanel.BackgroundImage = FilesList.Count == 0 ?
               new Bitmap(MFS.WinForms.Properties.Resources.undraw_empty_xct9) : default;

            foreach (var f in FilesList)
            {
                var thumbnail = new FileDisplayComponent(f, editMode);
                thumbnail.FileRemoved += (obj, id) => 
                {
                    Presenter.RemoveFile(id);
                    btnMyFiles_Click(null, EventArgs.Empty);
                };
                filesPanel.Controls.Add(thumbnail);
            }
        }

        private void StorageView_Load(object sender, EventArgs e)
        {
            btnMyFiles_Click(null, EventArgs.Empty);
        }

    }
}
