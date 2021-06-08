using MFS.Core.Services;
using MFS.WinForms.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MFS.WinForms.Forms
{
    public partial class MainForm : Form
    {

        private StorageView _storageView { get; set; }
        private ManageView _manageView { get; set; }

        public MainForm(
            StorageView storageView,
            ManageView manageView)
        {
            InitializeComponent();
            _storageView = storageView;
            _manageView = manageView;
            panelViews.Controls.Add(_storageView);
            panelViews.Controls.Add(_manageView);

            panel2.MouseDown += (s, e) =>
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            };
        }

        private void btnStorage_Click(object sender, EventArgs e)
        {
            _storageView.BringToFront();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure?",
               "Warning",
               MessageBoxButtons.YesNo,
               MessageBoxIcon.Information,
               MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                Environment.Exit(0);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            lblUsername.Text = CurrentUserService.Username;
        }

        private void timerDateTime_Tick(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToString("ddd, dd MMM yyy HH:mm:ss");
        }

        private void btnManage_Click(object sender, EventArgs e)
        {
            _manageView.LoadDropDowns();
            _manageView.BringToFront();
        }

        #region movable

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        private void MainForm_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
        }


        #endregion

    }
}
