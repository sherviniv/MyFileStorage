
namespace MFS.WinForms.Views
{
    partial class StorageView
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnShared = new System.Windows.Forms.Button();
            this.btnPublic = new System.Windows.Forms.Button();
            this.lbTitle = new System.Windows.Forms.Label();
            this.btnMyFiles = new System.Windows.Forms.Button();
            this.flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.btnUpload = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // btnShared
            // 
            this.btnShared.FlatAppearance.BorderSize = 0;
            this.btnShared.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShared.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.btnShared.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(86)))), ((int)(((byte)(226)))));
            this.btnShared.Location = new System.Drawing.Point(432, 42);
            this.btnShared.Name = "btnShared";
            this.btnShared.Size = new System.Drawing.Size(63, 27);
            this.btnShared.TabIndex = 8;
            this.btnShared.Text = "Shared";
            this.btnShared.UseVisualStyleBackColor = true;
            // 
            // btnPublic
            // 
            this.btnPublic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPublic.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.btnPublic.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(86)))), ((int)(((byte)(226)))));
            this.btnPublic.Location = new System.Drawing.Point(517, 42);
            this.btnPublic.Name = "btnPublic";
            this.btnPublic.Size = new System.Drawing.Size(72, 27);
            this.btnPublic.TabIndex = 9;
            this.btnPublic.Text = "Public";
            this.btnPublic.UseVisualStyleBackColor = true;
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(86)))), ((int)(((byte)(226)))));
            this.lbTitle.Location = new System.Drawing.Point(25, 35);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(102, 32);
            this.lbTitle.TabIndex = 10;
            this.lbTitle.Text = "Storage";
            // 
            // btnMyFiles
            // 
            this.btnMyFiles.FlatAppearance.BorderSize = 0;
            this.btnMyFiles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMyFiles.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.btnMyFiles.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(86)))), ((int)(((byte)(226)))));
            this.btnMyFiles.Location = new System.Drawing.Point(353, 42);
            this.btnMyFiles.Name = "btnMyFiles";
            this.btnMyFiles.Size = new System.Drawing.Size(63, 27);
            this.btnMyFiles.TabIndex = 8;
            this.btnMyFiles.Text = "My Files";
            this.btnMyFiles.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel
            // 
            this.flowLayoutPanel.BackColor = System.Drawing.SystemColors.MenuBar;
            this.flowLayoutPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.flowLayoutPanel.Location = new System.Drawing.Point(31, 125);
            this.flowLayoutPanel.Name = "flowLayoutPanel";
            this.flowLayoutPanel.Size = new System.Drawing.Size(558, 375);
            this.flowLayoutPanel.TabIndex = 11;
            // 
            // btnUpload
            // 
            this.btnUpload.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(86)))), ((int)(((byte)(226)))));
            this.btnUpload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpload.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpload.ForeColor = System.Drawing.SystemColors.Control;
            this.btnUpload.Location = new System.Drawing.Point(31, 89);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(96, 27);
            this.btnUpload.TabIndex = 9;
            this.btnUpload.Text = "Upload";
            this.btnUpload.UseVisualStyleBackColor = false;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // StorageView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(228)))), ((int)(((byte)(253)))));
            this.Controls.Add(this.flowLayoutPanel);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.btnMyFiles);
            this.Controls.Add(this.btnShared);
            this.Controls.Add(this.btnUpload);
            this.Controls.Add(this.btnPublic);
            this.Name = "StorageView";
            this.Size = new System.Drawing.Size(620, 520);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnShared;
        private System.Windows.Forms.Button btnPublic;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Button btnMyFiles;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
    }
}
