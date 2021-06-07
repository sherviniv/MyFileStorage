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

namespace MFS.WinForms.Forms
{
    public partial class UploadForm : Form
    {
        public event EventHandler<(string fileName,string filePath,bool isPublic)> FileSelected;

        public UploadForm()
        {
            InitializeComponent();
            openFileDialog.RestoreDirectory = true;
            openFileDialog.CheckFileExists = true;
            openFileDialog.CheckPathExists = true;
            openFileDialog.Filter = "Image (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png; |"
                                   + "Document (*.txt, *.doc, *.docx, *.pdf) | *.txt; *.doc; *.docx; *.pdf |"
                                   + "All | *.*";
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                txtSelectedFile.Text = openFileDialog.SafeFileName;
                FileSelected.Invoke(this, (txtFileName.Text, openFileDialog.FileName, chkPublic.Checked));
            }
        }

        private void lblCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
