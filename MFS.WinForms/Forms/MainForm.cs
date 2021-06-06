﻿using MFS.WinForms.Views;
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

        private StorageView  _storageView { get; set; }

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
    }
}
