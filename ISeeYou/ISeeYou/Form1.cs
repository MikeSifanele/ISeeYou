using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Windows.Forms;
using System.IO;

namespace ISeeYou
{
    public partial class Form1 : Form
    {

        Process[] myDriveMonitoring = null;
        string Directory_To_Monitor;
        StreamWriter myWriter;
        FileInfo myFile;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            try
            {
                fswDirectoryWatcher.Path = txtDirectoryPath.Text;
                fswDirectoryWatcher.EnableRaisingEvents = true;
                fswDirectoryWatcher.NotifyFilter = NotifyFilters.LastAccess | NotifyFilters.LastWrite | NotifyFilters.FileName | NotifyFilters.DirectoryName;

                btnStart.Enabled = false;
                btnStop.Enabled = true;

                btnStart.Text = "Monitoring..";
            }
            catch
            {

            }
            finally
            {

            }

        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            btnStop.Enabled = false;
            btnStart.Text = "Start Monitoring";
            btnStart.Enabled = true;

            fswDirectoryWatcher.EnableRaisingEvents = false;
        }

        private void btnGetDirectoryPath_Click(object sender, EventArgs e)
        {
            txtDirectoryPath.Text = Get_Directory_To_Monitor();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            

            try
            {
                

                if (txtDirectoryPath.Text.Trim(' ') == "")
                {
                    txtDirectoryPath.Text = Application.StartupPath.ToString();
                }

            }
            catch
            {
                MessageBox.Show("Could not set Directory to Monitor.", "Error");
            }
            finally
            {

                btnStop.Enabled = false;

            }
        }

        private void fswDirectoryWatcher_Created(object sender, FileSystemEventArgs e)
        {
            try
            {
                if(!e.FullPath.ToUpper().Contains(@"\AppData\".ToUpper()))
                {
                    Record_User_Activity(e);
                }
                
            }
            catch
            {

            }
            
        }

        private void fswDirectoryWatcher_Deleted(object sender, FileSystemEventArgs e)
        {
            try
            {
                if (!e.FullPath.ToUpper().Contains(@"\AppData\".ToUpper()))
                {
                    Record_User_Activity(e);
                }

            }
            catch
            {

            }
        }

        private void fswDirectoryWatcher_Renamed(object sender, RenamedEventArgs e)
        {
            try
            {
                if (!e.FullPath.ToUpper().Contains(@"\AppData\".ToUpper()))
                {
                    Record_User_Rename_Activity(e);
                }

            }
            catch
            {

            }
            
        }

        private void cbMonitorDrive_CheckedChanged(object sender, EventArgs e)
        {
            try
            {

                if (cbMonitorDrive.Checked)
                {
                    if (Process.GetProcessesByName("DriveMonitor").Count() < 1)
                    {
                        Process.Start(@"Drive Monitor\DriveMonitor.exe");
                    }
                }
                else
                {
                    myDriveMonitoring = Process.GetProcessesByName("DriveMonitor");

                    Process myProcess = myDriveMonitoring[0];

                    myProcess.Kill();
                }
            }
            catch
            {

            }
        }

        public string Get_Directory_To_Monitor()
        {
            //Get Directory to monitor.

            Directory_To_Monitor = "";

            try
            {
                using (FolderBrowserDialog dirMonitor = new FolderBrowserDialog() { SelectedPath = Path.GetDirectoryName(Application.StartupPath) })
                {
                    DialogResult myResult = dirMonitor.ShowDialog();

                    if (myResult == DialogResult.OK)
                    {
                        Directory_To_Monitor = dirMonitor.SelectedPath;
                    }
                    else
                    {
                        MessageBox.Show("Directory to monitor not set.", "Error");
                    }
                }
            }
            catch
            {
                MessageBox.Show("Directory to monitor not set.", "Error");
            }

            return Directory_To_Monitor;
        }

        public void Record_User_Rename_Activity(RenamedEventArgs re)
        {

            try
            {

                myFile = new FileInfo(re.FullPath);
                myWriter = new StreamWriter("User Activity Log.txt", true);

                if (myFile.Attributes.ToString().Contains("Directory") && !myFile.Attributes.ToString().Contains("Hidden"))
                {
                    myWriter.WriteLine($"Folder {re.ChangeType}|Actioned by: {Environment.UserName}|Time: {DateTime.Now}|Old Folder Name: {re.OldFullPath.Split('\\')[re.FullPath.Split('\\').Length - 1]}|New Folder Name: {re.FullPath.Split('\\')[re.FullPath.Split('\\').Length - 1]}|Folder Path: {re.FullPath}");
                }
                else if (!myFile.Attributes.ToString().Contains("Hidden"))
                {
                    myWriter.WriteLine($"File {re.ChangeType}|Actioned by: {Environment.UserName}|Time: {DateTime.Now}|Old File Name: {re.OldFullPath.Split('\\')[re.FullPath.Split('\\').Length - 1]}|New File Name: {re.FullPath.Split('\\')[re.FullPath.Split('\\').Length - 1]}|File Path: {re.FullPath}");
                }
            }
            catch (Exception ex)
            {
                myWriter.Close();
                MessageBox.Show(ex.Message, "Error - Logging User Activity");
            }
            finally
            {
                myWriter.Close();
                myFile = null;
                re = null;
            }
        }

        public void Record_User_Activity(FileSystemEventArgs e)
        {

            try
            {
                myFile = new FileInfo(e.FullPath);
                myWriter = new StreamWriter("User Activity Log.txt", true);

                if (myFile.Attributes.ToString().Contains("Directory"))
                {
                    myWriter.WriteLine($"Folder {e.ChangeType}|Actioned by: {Environment.UserName}|Time: {DateTime.Now}|Folder Name: {e.FullPath.Split('\\')[e.FullPath.Split('\\').Length - 1]}|Folder Path: {e.FullPath}");

                }
                else
                {
                    myWriter.WriteLine($"File {e.ChangeType}|Actioned by: {Environment.UserName}|Time: {DateTime.Now}|File Name: {e.FullPath.Split('\\')[e.FullPath.Split('\\').Length - 1]}|File Path: {e.FullPath}");

                }
            }
            catch (Exception ex)
            {
                myWriter.Close();
                MessageBox.Show(ex.Message, "Error - Logging User Activity");
            }
            finally
            {
                myWriter.Close();
                myFile = null;
                e = null;
            }
        }

        private void fswDirectoryWatcher_Changed(object sender, FileSystemEventArgs e)
        {
            if (!e.FullPath.ToUpper().Contains(@"\AppData\".ToUpper()))
            {
                MessageBox.Show($"{e.FullPath} {e.ChangeType.ToString()}");
            }
        }
    }

}

