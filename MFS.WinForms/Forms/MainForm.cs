﻿using MFS.Core.Services;
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

        public MainForm(StorageView storageView)
        {
            InitializeComponent();
            _storageView = storageView;
            panelViews.Controls.Add(_storageView);
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
    }
}
