
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
            this.lblFormat = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.lblCreated = new System.Windows.Forms.Label();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.picThumb)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(86)))), ((int)(((byte)(226)))));
            this.lblTitle.Location = new System.Drawing.Point(2, 117);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(68, 17);
            this.lblTitle.TabIndex = 3;
            this.lblTitle.Text = "File Name";
            // 
            // lblFileSize
            // 
            this.lblFileSize.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFileSize.Location = new System.Drawing.Point(106, 117);
            this.lblFileSize.Name = "lblFileSize";
            this.lblFileSize.Size = new System.Drawing.Size(49, 17);
            this.lblFileSize.TabIndex = 3;
            this.lblFileSize.Text = "size";
            this.lblFileSize.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // picThumb
            // 
            this.picThumb.BackColor = System.Drawing.SystemColors.Control;
            this.picThumb.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picThumb.Image = global::MFS.WinForms.Properties.Resources.undraw_No_data_re_kwbl;
            this.picThumb.Location = new System.Drawing.Point(3, 3);
            this.picThumb.Name = "picThumb";
            this.picThumb.Size = new System.Drawing.Size(152, 98);
            this.picThumb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picThumb.TabIndex = 2;
            this.picThumb.TabStop = false;
            // 
            // lblFormat
            // 
            this.lblFormat.BackColor = System.Drawing.Color.Transparent;
            this.lblFormat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblFormat.Font = new System.Drawing.Font("B Yekan", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblFormat.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblFormat.Location = new System.Drawing.Point(3, 18);
            this.lblFormat.Name = "lblFormat";
            this.lblFormat.Size = new System.Drawing.Size(152, 74);
            this.lblFormat.TabIndex = 4;
            this.lblFormat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSave.Location = new System.Drawing.Point(3, 137);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(86, 27);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.Tomato;
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemove.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.ForeColor = System.Drawing.SystemColors.Control;
            this.btnRemove.Location = new System.Drawing.Point(95, 137);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(60, 27);
            this.btnRemove.TabIndex = 11;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // lblCreated
            // 
            this.lblCreated.AutoSize = true;
            this.lblCreated.Font = new System.Drawing.Font("Segoe UI", 7F);
            this.lblCreated.Location = new System.Drawing.Point(3, 102);
            this.lblCreated.Name = "lblCreated";
            this.lblCreated.Size = new System.Drawing.Size(53, 12);
            this.lblCreated.TabIndex = 3;
            this.lblCreated.Text = "create date";
            this.lblCreated.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // FileDisplayComponent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblFormat);
            this.Controls.Add(this.lblCreated);
            this.Controls.Add(this.lblFileSize);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.picThumb);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.Name = "FileDisplayComponent";
            this.Size = new System.Drawing.Size(158, 166);
            ((System.ComponentModel.ISupportInitialize)(this.picThumb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picThumb;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblFileSize;
        private System.Windows.Forms.Label lblFormat;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Label lblCreated;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
    }
}
