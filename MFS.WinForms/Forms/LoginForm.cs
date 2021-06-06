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

namespace MFS.WinForms.Forms
{
    public partial class LoginForm : Form, ILoginView
    {
        public LoginPresenter Presenter { get; set; }
        public Form _registerForm { get; set; }
        public string Username { get => txtUsername.Text; set => txtUsername.Text = value; }
        public string Password { get => txtPassword.Text; set => txtPassword.Text = value; }
        public string Message { get => lblMessage.Text; set => lblMessage.Text = value; }
        public bool RememberMe { get => chkRemmeberMe.Checked; set => chkRemmeberMe.Checked = value; }
        public LoginForm(Form registerForm)
        {
            InitializeComponent();
            _registerForm = registerForm;
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            Presenter.ReadCredentials();
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

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Presenter.Authenticate();
        }

        private void lblRegister_Click(object sender, EventArgs e)
        {
            Username = string.Empty;
            Password = string.Empty;
            Hide();
            _registerForm.Show();
        }
    }
}
