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
    public partial class RegisterForm : Form, IRegisterView
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {
            Presenter.ResetInputs();
        }

        public RegisterPresenter Presenter { get; set; }
        public Form LoginForm { get; set; }
        public string Username { get => txtUsername.Text; set => txtUsername.Text = value; }
        public string FullName { get => txtFullname.Text; set => txtFullname.Text = value; }
        public string Password { get => txtPassword.Text; set => txtPassword.Text = value; }
        public string RePassword { get => txtRePassword.Text; set => txtRePassword.Text = value; }
        public string Email { get => txtEmail.Text; set => txtEmail.Text = value; }
        public string Message { get => lblMessage.Text; set => lblMessage.Text = value; }

        private void lbLogin_Click(object sender, EventArgs e)
        {
            Hide();
            LoginForm.Show();
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

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (Presenter.RegisterUser())
            {
                MessageBox.Show("Registration done succesfuly!");
                Message = "";
                Presenter.ResetInputs();
                Hide();
                LoginForm.Show();
            }
        }

    }
}
