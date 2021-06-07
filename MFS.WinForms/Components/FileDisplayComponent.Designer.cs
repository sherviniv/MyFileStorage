
namespace MFS.WinForms.Components
{
    partial class FileDisplayComponent
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblFileSize = new System.Windows.Forms.Label();
            this.picThumb = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picThumb)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(3, 127);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(57, 13);
            this.lblTitle.TabIndex = 3;
            this.lblTitle.Text = "File Name";
            // 
            // lblFileSize
            // 
            this.lblFileSize.AutoSize = true;
            this.lblFileSize.Location = new System.Drawing.Point(98, 127);
            this.lblFileSize.Name = "lblFileSize";
            this.lblFileSize.Size = new System.Drawing.Size(57, 13);
            this.lblFileSize.TabIndex = 3;
            this.lblFileSize.Text = "File Name";
            // 
            // picThumb
            // 
            this.picThumb.BackColor = System.Drawing.SystemColors.Control;
            this.picThumb.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picThumb.Image = global::MFS.WinForms.Properties.Resources.undraw_No_data_re_kwbl;
            this.picThumb.Location = new System.Drawing.Point(3, 3);
            this.picThumb.Name = "picThumb";
            this.picThumb.Size = new System.Drawing.Size(152, 121);
            this.picThumb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picThumb.TabIndex = 2;
            this.picThumb.TabStop = false;
            // 
            // FileDisplayComponent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblFileSize);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.picThumb);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.Name = "FileDisplayComponent";
            this.Size = new System.Drawing.Size(158, 158);
            ((System.ComponentModel.ISupportInitialize)(this.picThumb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picThumb;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblFileSize;
    }
}
