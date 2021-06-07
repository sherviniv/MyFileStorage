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

        private void btnUpload_Click(object sender, EventArgs e)
        {
            using (var uploadForm = new UploadForm())
            {
                uploadForm.FileSelected += (obj, selectedFile) =>
                {
                    Presenter.UploadFile(selectedFile.fileName, selectedFile.filePath, selectedFile.isPublic);
                };
                uploadForm.ShowDialog();
            }
        }
    }
}
