
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
            this.filesPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.btnUpload = new System.Windows.Forms.Button();
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
            this.btnShared.Click += new System.EventHandler(this.btnShared_Click);
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
            this.btnPublic.Click += new System.EventHandler(this.btnPublic_Click);
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
            this.btnMyFiles.Click += new System.EventHandler(this.btnMyFiles_Click);
            // 
            // filesPanel
            // 
            this.filesPanel.AutoScroll = true;
            this.filesPanel.BackColor = System.Drawing.SystemColors.MenuBar;
            this.filesPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.filesPanel.Location = new System.Drawing.Point(31, 125);
            this.filesPanel.Name = "filesPanel";
            this.filesPanel.Size = new System.Drawing.Size(516, 375);
            this.filesPanel.TabIndex = 11;
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
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // StorageView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.filesPanel);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.btnMyFiles);
            this.Controls.Add(this.btnShared);
            this.Controls.Add(this.btnUpload);
            this.Controls.Add(this.btnPublic);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F);
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
        private System.Windows.Forms.FlowLayoutPanel filesPanel;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
    }
}
