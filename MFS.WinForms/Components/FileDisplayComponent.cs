using MFS.Persistence.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MFS.WinForms.Components
{
    public partial class FileDisplayComponent : UserControl
    {
        public FileDisplayComponent(StorageFile file)
        {
            InitializeComponent();
            lblFormat.Parent = picThumb;
            lblFormat.BackColor = System.Drawing.Color.Transparent;
            lblTitle.Text = file.FileName;
            lblFileSize.Text = (file.FileSize /1024).ToString("N0") + "kb";
            lblFormat.Text = file.FileType;
        }
    }
}
