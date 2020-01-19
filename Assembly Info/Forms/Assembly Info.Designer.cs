namespace bhojarajsahu88.Assembly_Info.Forms
{
    partial class Assembly_Info
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonBrowse = new System.Windows.Forms.Button();
            this.labelFileName = new System.Windows.Forms.Label();
            this.labelFilePath = new System.Windows.Forms.Label();
            this.openFileDialogBrowse = new System.Windows.Forms.OpenFileDialog();
            this.groupBoxSelectFile = new System.Windows.Forms.GroupBox();
            this.groupBoxInfo = new System.Windows.Forms.GroupBox();
            this.dataGridViewInfo = new System.Windows.Forms.DataGridView();
            this.groupBoxSelectFile.SuspendLayout();
            this.groupBoxInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonBrowse
            // 
            this.buttonBrowse.Location = new System.Drawing.Point(27, 24);
            this.buttonBrowse.Name = "buttonBrowse";
            this.buttonBrowse.Size = new System.Drawing.Size(75, 23);
            this.buttonBrowse.TabIndex = 0;
            this.buttonBrowse.Text = "Browse";
            this.buttonBrowse.UseVisualStyleBackColor = true;
            this.buttonBrowse.Click += new System.EventHandler(this.buttonBrowse_Click);
            // 
            // labelFileName
            // 
            this.labelFileName.AutoSize = true;
            this.labelFileName.Location = new System.Drawing.Point(119, 29);
            this.labelFileName.Name = "labelFileName";
            this.labelFileName.Size = new System.Drawing.Size(54, 13);
            this.labelFileName.TabIndex = 1;
            this.labelFileName.Text = "File Name";
            // 
            // labelFilePath
            // 
            this.labelFilePath.AutoSize = true;
            this.labelFilePath.Location = new System.Drawing.Point(119, 51);
            this.labelFilePath.Name = "labelFilePath";
            this.labelFilePath.Size = new System.Drawing.Size(48, 13);
            this.labelFilePath.TabIndex = 2;
            this.labelFilePath.Text = "File Path";
            // 
            // openFileDialogBrowse
            // 
            this.openFileDialogBrowse.FileName = "openFileDialog1";
            this.openFileDialogBrowse.Filter = "Executable Files|*.exe|Assembly Files|*.dll";
            // 
            // groupBoxSelectFile
            // 
            this.groupBoxSelectFile.Controls.Add(this.labelFilePath);
            this.groupBoxSelectFile.Controls.Add(this.labelFileName);
            this.groupBoxSelectFile.Controls.Add(this.buttonBrowse);
            this.groupBoxSelectFile.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxSelectFile.Location = new System.Drawing.Point(0, 0);
            this.groupBoxSelectFile.Name = "groupBoxSelectFile";
            this.groupBoxSelectFile.Size = new System.Drawing.Size(594, 86);
            this.groupBoxSelectFile.TabIndex = 2;
            this.groupBoxSelectFile.TabStop = false;
            this.groupBoxSelectFile.Text = "Select File";
            // 
            // groupBoxInfo
            // 
            this.groupBoxInfo.Controls.Add(this.dataGridViewInfo);
            this.groupBoxInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxInfo.Location = new System.Drawing.Point(0, 86);
            this.groupBoxInfo.Name = "groupBoxInfo";
            this.groupBoxInfo.Size = new System.Drawing.Size(594, 260);
            this.groupBoxInfo.TabIndex = 3;
            this.groupBoxInfo.TabStop = false;
            this.groupBoxInfo.Text = "Assembly Info";
            // 
            // dataGridViewInfo
            // 
            this.dataGridViewInfo.AllowUserToAddRows = false;
            this.dataGridViewInfo.AllowUserToDeleteRows = false;
            this.dataGridViewInfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewInfo.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridViewInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewInfo.Location = new System.Drawing.Point(3, 16);
            this.dataGridViewInfo.Name = "dataGridViewInfo";
            this.dataGridViewInfo.ReadOnly = true;
            this.dataGridViewInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewInfo.Size = new System.Drawing.Size(588, 241);
            this.dataGridViewInfo.TabIndex = 0;
            // 
            // Assembly_Info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 346);
            this.Controls.Add(this.groupBoxInfo);
            this.Controls.Add(this.groupBoxSelectFile);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MinimumSize = new System.Drawing.Size(610, 380);
            this.Name = "Assembly_Info";
            this.Text = "Assembly Info";
            this.Load += new System.EventHandler(this.Assembly_Info_Load);
            this.groupBoxSelectFile.ResumeLayout(false);
            this.groupBoxSelectFile.PerformLayout();
            this.groupBoxInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInfo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonBrowse;
        private System.Windows.Forms.Label labelFilePath;
        private System.Windows.Forms.Label labelFileName;
        private System.Windows.Forms.OpenFileDialog openFileDialogBrowse;
        private System.Windows.Forms.GroupBox groupBoxSelectFile;
        private System.Windows.Forms.GroupBox groupBoxInfo;
        private System.Windows.Forms.DataGridView dataGridViewInfo;
    }
}