using MFS.WinForms.Interfaces;
using MFS.WinForms.Models;
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
    public partial class ManageView : UserControl, IManageView
    {
        public ManageView()
        {
            InitializeComponent();
        }

        public ManagePresenter Presenter { get; set; }
        public List<FilePermissionViewModel> FPList { get; set; }

        public void RenderGrid()
        {
            Presenter.GetGridInfo();
            var list = new BindingList<FilePermissionViewModel>(FPList);
            gridFiles.DataSource = list;
            gridFiles.Columns[0].Visible = false;
        }

        private void ManageView_Load(object sender, EventArgs e)
        {
            RenderGrid();
            LoadDropDowns();
        }

        public void LoadDropDowns() 
        {
            cmbUsers.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbUsers.DisplayMember = "Value";
            cmbUsers.ValueMember = "Key";
            cmbUsers.DataSource = new BindingSource(Presenter.GetUsers(), null);
            cmbUsers.SelectedIndex = -1;

            cmbFiles.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbFiles.DisplayMember = "Value";
            cmbFiles.ValueMember = "Key";
            cmbFiles.DataSource = new BindingSource(Presenter.GetFiles(), null);
            cmbFiles.SelectedIndex = -1;

            cmbPermissionType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPermissionType.DisplayMember = "Value";
            cmbPermissionType.ValueMember = "Key";
            cmbPermissionType.DataSource = new BindingSource(Presenter.GetPermissionTypes(), null);
            cmbPermissionType.SelectedIndex = -1;
        }

        private void btnGrant_Click(object sender, EventArgs e)
        {
            if (cmbPermissionType.SelectedIndex == -1 ||
                cmbFiles.SelectedIndex == -1 ||
                cmbUsers.SelectedIndex == -1)
            {
                MessageBox.Show("Please select");
                return;
            }

            Presenter.GrantAccess((int)cmbUsers.SelectedValue, (int)cmbFiles.SelectedValue, (int)cmbPermissionType.SelectedValue);
            cmbPermissionType.SelectedIndex = -1;
            cmbFiles.SelectedIndex = -1;
            cmbUsers.SelectedIndex = -1;
            RenderGrid();
        }

        private void removeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var ids = new List<int>();
            foreach (DataGridViewRow row in gridFiles.SelectedRows)
            {
                ids.Add((int)row.Cells[0].Value);
            }

            if (!ids.Any())
            {
                MessageBox.Show("Please atleast select one record", "warning",
                     MessageBoxButtons.OK,
                     MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show($"Are you sure to remove {ids.Count} rows?", "warning",
                     MessageBoxButtons.OKCancel,
                     MessageBoxIcon.Warning,
                     MessageBoxDefaultButton.Button1) == DialogResult.OK)
            {
                foreach (var id in ids)
                {
                    Presenter.RemoveGrant(id);
                }
                RenderGrid();
            };
        }

        private void gridFiles_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {

                int currentMouseOverRow = gridFiles.HitTest(e.X, e.Y).RowIndex;

                if (currentMouseOverRow >= 0)
                {
                    contextMenuGrid.Show(gridFiles, new Point(e.X, e.Y));
                }
            }
        }
    }
}
