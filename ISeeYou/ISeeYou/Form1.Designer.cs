namespace ISeeYou
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtDirectoryPath = new System.Windows.Forms.TextBox();
            this.btnGetDirectoryPath = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.fswDirectoryWatcher = new System.IO.FileSystemWatcher();
            this.cbMonitorDrive = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.fswDirectoryWatcher)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(261, 48);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(184, 37);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "File Monitor";
            // 
            // txtDirectoryPath
            // 
            this.txtDirectoryPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDirectoryPath.Location = new System.Drawing.Point(12, 112);
            this.txtDirectoryPath.Name = "txtDirectoryPath";
            this.txtDirectoryPath.Size = new System.Drawing.Size(535, 39);
            this.txtDirectoryPath.TabIndex = 2;
            // 
            // btnGetDirectoryPath
            // 
            this.btnGetDirectoryPath.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGetDirectoryPath.FlatAppearance.BorderSize = 4;
            this.btnGetDirectoryPath.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGetDirectoryPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetDirectoryPath.Location = new System.Drawing.Point(555, 112);
            this.btnGetDirectoryPath.Name = "btnGetDirectoryPath";
            this.btnGetDirectoryPath.Size = new System.Drawing.Size(140, 45);
            this.btnGetDirectoryPath.TabIndex = 3;
            this.btnGetDirectoryPath.Text = "Browse";
            this.btnGetDirectoryPath.UseVisualStyleBackColor = true;
            this.btnGetDirectoryPath.Click += new System.EventHandler(this.btnGetDirectoryPath_Click);
            // 
            // btnStop
            // 
            this.btnStop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStop.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnStop.FlatAppearance.BorderSize = 4;
            this.btnStop.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStop.Location = new System.Drawing.Point(456, 262);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(238, 52);
            this.btnStop.TabIndex = 4;
            this.btnStop.Text = "Stop Monitoring";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnStart
            // 
            this.btnStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStart.FlatAppearance.BorderSize = 4;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(12, 262);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(246, 52);
            this.btnStart.TabIndex = 5;
            this.btnStart.Text = "Start Monitoring";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // fswDirectoryWatcher
            // 
            this.fswDirectoryWatcher.EnableRaisingEvents = true;
            this.fswDirectoryWatcher.IncludeSubdirectories = true;
            this.fswDirectoryWatcher.NotifyFilter = System.IO.NotifyFilters.FileName;
            this.fswDirectoryWatcher.SynchronizingObject = this;
            this.fswDirectoryWatcher.Changed += new System.IO.FileSystemEventHandler(this.fswDirectoryWatcher_Changed);
            this.fswDirectoryWatcher.Created += new System.IO.FileSystemEventHandler(this.fswDirectoryWatcher_Created);
            this.fswDirectoryWatcher.Deleted += new System.IO.FileSystemEventHandler(this.fswDirectoryWatcher_Deleted);
            this.fswDirectoryWatcher.Renamed += new System.IO.RenamedEventHandler(this.fswDirectoryWatcher_Renamed);
            // 
            // cbMonitorDrive
            // 
            this.cbMonitorDrive.AutoSize = true;
            this.cbMonitorDrive.BackColor = System.Drawing.Color.Transparent;
            this.cbMonitorDrive.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbMonitorDrive.FlatAppearance.BorderSize = 4;
            this.cbMonitorDrive.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMonitorDrive.ForeColor = System.Drawing.Color.White;
            this.cbMonitorDrive.Location = new System.Drawing.Point(12, 190);
            this.cbMonitorDrive.Name = "cbMonitorDrive";
            this.cbMonitorDrive.Size = new System.Drawing.Size(241, 36);
            this.cbMonitorDrive.TabIndex = 7;
            this.cbMonitorDrive.Text = "Monitor Drive(s)";
            this.cbMonitorDrive.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cbMonitorDrive.UseVisualStyleBackColor = false;
            this.cbMonitorDrive.CheckedChanged += new System.EventHandler(this.cbMonitorDrive_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(710, 327);
            this.Controls.Add(this.cbMonitorDrive);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnGetDirectoryPath);
            this.Controls.Add(this.txtDirectoryPath);
            this.Controls.Add(this.lblTitle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "ISeeYou";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fswDirectoryWatcher)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtDirectoryPath;
        private System.Windows.Forms.Button btnGetDirectoryPath;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnStart;
        private System.IO.FileSystemWatcher fswDirectoryWatcher;
        private System.Windows.Forms.CheckBox cbMonitorDrive;
    }
}

