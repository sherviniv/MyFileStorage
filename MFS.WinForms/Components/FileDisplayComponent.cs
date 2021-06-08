using MFS.Persistence.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MFS.WinForms.Components
{
    public partial class FileDisplayComponent : UserControl
    {
        public event EventHandler<int> FileRemoved;
        public StorageFile CurrentFile { get; set; }
        public readonly List<string> ImageExtensions = new List<string> { ".JPG", ".JPE", ".BMP", ".GIF", ".PNG" };
        public FileDisplayComponent(StorageFile file,bool editMode)
        {
            InitializeComponent();
            CurrentFile = file;
            lblFormat.Parent = picThumb;
            lblFormat.BackColor = System.Drawing.Color.Transparent;
            lblTitle.Text = file.FileName;
            lblFileSize.Text = (file.FileSize / 1024).ToString("N0") + "kb";
            lblFormat.Text = file.FileType;
            lblCreated.Text = "Stored at " + file.CreateDate.ToString();
            if (ImageExtensions.Contains(file.FileType.ToUpperInvariant()))
            {
                picThumb.Image = ConvertToImage(file.FileContent);
            }
            btnRemove.Visible = editMode;
        }

        public Image ConvertToImage(byte[] binary)
        {
            MemoryStream ms = new MemoryStream(binary);
            return Image.FromStream(ms);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure?",
            "Warning",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Warning,
            MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                FileRemoved.Invoke(this, CurrentFile.ID);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            saveFileDialog.FileName = CurrentFile.FileName;
            saveFileDialog.DefaultExt = CurrentFile.FileType;
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllBytes(saveFileDialog.FileName, CurrentFile.FileContent);
            }
        }
    }
}
