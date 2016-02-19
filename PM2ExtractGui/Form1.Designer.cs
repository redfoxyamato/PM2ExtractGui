namespace PM2ExtractGui
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.lb4FilePath = new System.Windows.Forms.TextBox();
            this.openFile = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.extractPath = new System.Windows.Forms.TextBox();
            this.openFolder = new System.Windows.Forms.Button();
            this.Extract = new System.Windows.Forms.Button();
            this.lb4File = new System.Windows.Forms.OpenFileDialog();
            this.extractFolder = new System.Windows.Forms.FolderBrowserDialog();
            this.update = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "Archive:";
            // 
            // lb4FilePath
            // 
            this.lb4FilePath.Location = new System.Drawing.Point(80, 10);
            this.lb4FilePath.Name = "lb4FilePath";
            this.lb4FilePath.ReadOnly = true;
            this.lb4FilePath.Size = new System.Drawing.Size(317, 19);
            this.lb4FilePath.TabIndex = 1;
            // 
            // openFile
            // 
            this.openFile.Location = new System.Drawing.Point(403, 8);
            this.openFile.Name = "openFile";
            this.openFile.Size = new System.Drawing.Size(26, 23);
            this.openFile.TabIndex = 2;
            this.openFile.Text = "...";
            this.openFile.UseVisualStyleBackColor = true;
            this.openFile.Click += new System.EventHandler(this.openFile_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "Extract dir:";
            // 
            // extractPath
            // 
            this.extractPath.Location = new System.Drawing.Point(80, 35);
            this.extractPath.Name = "extractPath";
            this.extractPath.ReadOnly = true;
            this.extractPath.Size = new System.Drawing.Size(317, 19);
            this.extractPath.TabIndex = 4;
            // 
            // openFolder
            // 
            this.openFolder.Location = new System.Drawing.Point(403, 35);
            this.openFolder.Name = "openFolder";
            this.openFolder.Size = new System.Drawing.Size(26, 23);
            this.openFolder.TabIndex = 5;
            this.openFolder.Text = "....";
            this.openFolder.UseVisualStyleBackColor = true;
            this.openFolder.Click += new System.EventHandler(this.openFolder_Click);
            // 
            // Extract
            // 
            this.Extract.Enabled = false;
            this.Extract.Location = new System.Drawing.Point(155, 73);
            this.Extract.Name = "Extract";
            this.Extract.Size = new System.Drawing.Size(75, 23);
            this.Extract.TabIndex = 6;
            this.Extract.Text = "Extract";
            this.Extract.UseVisualStyleBackColor = true;
            this.Extract.Click += new System.EventHandler(this.Extract_Click);
            // 
            // lb4File
            // 
            this.lb4File.Filter = "LB4 Archive(*.LB4)|*.LB4";
            this.lb4File.FileOk += new System.ComponentModel.CancelEventHandler(this.lb4File_FileOk);
            // 
            // update
            // 
            this.update.Enabled = true;
            this.update.Tick += new System.EventHandler(this.update_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 112);
            this.Controls.Add(this.Extract);
            this.Controls.Add(this.openFolder);
            this.Controls.Add(this.extractPath);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.openFile);
            this.Controls.Add(this.lb4FilePath);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.Text = "PM2Extract";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox lb4FilePath;
        private System.Windows.Forms.Button openFile;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox extractPath;
        private System.Windows.Forms.Button openFolder;
        private System.Windows.Forms.Button Extract;
        private System.Windows.Forms.OpenFileDialog lb4File;
        private System.Windows.Forms.FolderBrowserDialog extractFolder;
        private System.Windows.Forms.Timer update;
    }
}

