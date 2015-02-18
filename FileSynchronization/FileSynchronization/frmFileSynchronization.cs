using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Data.OleDb;
using System.Threading;
using System.Collections;
using FileSyncUtilities;
using DatabaseUtilities;
using ControlUtilities;

namespace FileSynchronization
{
    public partial class frmFileSync : Form
    {
        private DBUtil dbUtilities;
        private List<FileSync> filesToProcess;
        private OleDbDataReader dr;
        private string processID;
        private bool isUpdate;
        public frmFileSync()
        {
            InitializeComponent();
            dbUtilities = new DBUtil();
            filesToProcess = new List<FileSync>();
            processID = "";
        }
        private void frmFileSync_Load(object sender, EventArgs e)
        {
            if (!DBUtil.isSuccess)
            {
                MessageBox.Show("This progam will exit.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                this.Close();
            }
            PopulateListView();
            ControlSettings.SetComboToFirstItem(cmbSelected);
            ControlSettings.SetComboToFirstItem(cmbNameFormat);
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {
        }
        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }
        private void addTaskToolStripMenuItem_Click(object sender, EventArgs e)
        {
            grpAddTask.Enabled = true;
            grpScheduledTask.Enabled = false;
            isUpdate = false;
        }
        private void btnRun_Click(object sender, EventArgs e)
        {
            int counter = 0;
            if (lstTasks.Items.Count == 0) return;
            DialogResult dlgResult = MessageBox.Show("This will run file synchronization on the selected files. Proceed?", "Run File Sync", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlgResult == DialogResult.Yes)
            {
                progressBar1.Visible = true;
                OleDbDataReader dr = dbUtilities.ExecuteQuery("SELECT * FROM tblSettings WHERE Selected = TRUE ORDER BY DateUpdated");
                while (dr.Read())
                {
                    filesToProcess.Add(new FileSync(dr["ClientName"].ToString(), dr["PathName"].ToString(), dr["DestinationName"].ToString(), (dr["Overwrite"].ToString().Equals("True") ? true : false), dr["FileFormat"].ToString()));
                    int num = progressBar1.Value + (100 / Convert.ToInt32(lstTasks.Items.Count));
                    progressBar1.Value = ( num > 100? 100: num );
                }
                dr.Close();

                txtSyncStatus.Text += "<-----File Sync run at " + DateTime.Now.ToString() + " by " + Environment.MachineName +  "----->" + Environment.NewLine;
                foreach(FileSync file in filesToProcess)
                {
                    counter++;
                    file.runFileSync();
                    txtSyncStatus.Text += counter.ToString() + " " + file.GetStatusReport() + Environment.NewLine;
                }
                txtSyncStatus.Text += "<---------------------End Sync Process--------------------->" + Environment.NewLine + Environment.NewLine + Environment.NewLine;
                
                string logPath = @"C:\FileSyncLog\FileSyncLog.log";
                if (!File.Exists(logPath))
                    Directory.CreateDirectory(@"C:\FileSyncLog");



                File.AppendAllText(@"C:\FileSyncLog\FileSyncLog.log", txtSyncStatus.Text);
                filesToProcess.Clear();
                MessageBox.Show("File Synchronization succesfuly carried out.", "Run File Sync", MessageBoxButtons.OK, MessageBoxIcon.Information);
                progressBar1.Visible = false;
                progressBar1.Value = 1;
            }
        }

        private void tmrFileSync_Tick(object sender, EventArgs e)
        {
            if (frmAddTask.recordSaved)
            {
                Thread.Sleep(1000);
                btnRun_Click(sender, e);
                tmrFileSync.Enabled = false;
            }
        }

        public void PopulateListView()
        {
            int counter = 0;
            string sql = "SELECT * FROM tblSettings ORDER BY DateUpdated DESC";
            dr = dbUtilities.ExecuteQuery(sql);

            lstTasks.Items.Clear();
   
            while (dr.Read())
            {
                counter++;
                ListViewItem itm = new ListViewItem(dr["SettingsID"].ToString());
                itm.SubItems.Add(counter.ToString());
                itm.SubItems.Add(dr["ClientName"].ToString());
                itm.SubItems.Add(dr["PathName"].ToString());
                itm.SubItems.Add(dr["DestinationName"].ToString());
                itm.SubItems.Add((dr["Selected"].ToString().Equals("True") ? "Yes" : "No"));
                //lstTasks.Items.AddRange(new ListViewItem[] { itm });
                lstTasks.Items.Add(itm);
            }
            dr.Close();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (isAllRequiredFieldsHasValue())
            {
                switch (isUpdate)
                {
                    case false:
                        SaveNewTask();
                        break;
                    default:
                        UpdateTask();
                        break;
                }
            }
        }
        private void UpdateTask()
        {
            string sql = "UPDATE tblSettings SET ClientName ='" + txtClientName.Text + "', PathName = '" + txtSourcePath.Text + "', " +
                         "DestinationName = '" + txtDestinationPath.Text + "', Overwrite = " + optOverwrite.Checked + ", CreateBak = " + optCreateBak.Checked + "," +
                         "FileFormat ='" + cmbNameFormat.Text + "', DateUpdated = Now(), UpdatedBy ='" + Environment.MachineName + "'," +
                         "Selected = " + cmbSelected.Text + " WHERE SettingsID = '" + processID + "'";
            DialogResult res = MessageBox.Show("Are you sure you want to update the task?", "Update Task", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                dbUtilities.ExecuteUpdate(sql);
                MessageBox.Show("Settings updated!", "Update Task", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ControlSettings.SetTextToNull(grpAddTask);
                ControlSettings.SetComboToFirstItem(cmbNameFormat);
                ControlSettings.SetAllRadioButtonToFalse(grpAddTask);
                cmbSelected.SelectedIndex = 1;

                PopulateListView();
                grpAddTask.Enabled = false;
                grpScheduledTask.Enabled = true;
            }
        }
        private void SaveNewTask()
        {
            //MessageBox.Show(dbUtilities.GenID(false, 10));
            string sql = "INSERT INTO tblSettings VALUES ('" + dbUtilities.GenID(false, 10) + "','" + txtClientName.Text + "'," +
                         "'" + txtSourcePath.Text + "','" + txtDestinationPath.Text + "'," + optCreateBak.Checked + "," +
                         "" + optOverwrite.Checked + ",'" + cmbNameFormat.Text + "',#" + DateTime.Now.ToString() + "#,'" + Environment.MachineName + "'," + cmbSelected.Text + ")";
            DialogResult res = MessageBox.Show("This will save your settings. Continue saving?", "Save Settings", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                dbUtilities.ExecuteUpdate(sql);
                MessageBox.Show("Settings saved!", "Save Settings", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ControlSettings.SetTextToNull(grpAddTask);
                ControlSettings.SetComboToFirstItem(cmbNameFormat);
                ControlSettings.SetAllRadioButtonToFalse(grpAddTask);
                cmbSelected.SelectedIndex = 1;

                PopulateListView();
                grpAddTask.Enabled = false;
                grpScheduledTask.Enabled = true;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            grpAddTask.Enabled = false;
            grpScheduledTask.Enabled = true;
            ControlSettings.SetTextToNull(grpAddTask);
            ControlSettings.SetComboToFirstItem(cmbNameFormat);
            ControlSettings.SetAllRadioButtonToFalse(grpAddTask);
            cmbSelected.SelectedIndex = 1;
        }

        private bool isAllRequiredFieldsHasValue()
        {
            txtClientName.Text = ControlSettings.RemoveQuotes(txtClientName.Text);
            return ControlSettings.isAllTextHasValue(grpAddTask) && ControlSettings.isRadioSelected(grpAddTask) && !cmbNameFormat.Text.Contains("<");
        }

        private void btnBrowSource_Click(object sender, EventArgs e)
        {
            txtSourcePath.Text = dbUtilities.RunOpenDialog("Select the file to be copied from.");
        }

        private void btnBrowDesti_Click(object sender, EventArgs e)
        {
            string destPath = dbUtilities.RunFolderBrowserDialog();
            if (!destPath.Equals(""))
                txtDestinationPath.Text = destPath;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (lstTasks.SelectedItems.Count != 0)
            {
                grpAddTask.Enabled = true;
                grpScheduledTask.Enabled = false;
                processID = lstTasks.SelectedItems[0].Text;
                isUpdate = true;
                dr = dbUtilities.ExecuteQuery("SELECT * FROM tblSettings WHERE SettingsID ='" + processID + "'");
                dr.Read();
                    txtClientName.Text = dr["ClientName"].ToString();
                    txtSourcePath.Text = dr["PathName"].ToString();
                    txtDestinationPath.Text = dr["DestinationName"].ToString();
                    optCreateBak.Checked = Convert.ToBoolean(dr["CreateBak"]);
                    optOverwrite.Checked = Convert.ToBoolean(dr["Overwrite"]);
                    cmbNameFormat.Text =  dr["FileFormat"].ToString();
                    cmbSelected.Text = (dr["Selected"].ToString().Equals("True") ? "YES" : "NO");
                dr.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var selectedItems = lstTasks.CheckedItems;
            string retVal = "";
            foreach (ListViewItem selectedItem in selectedItems)
            {
                retVal += selectedItem.SubItems[1].Text + Environment.NewLine;
            }
            MessageBox.Show(retVal);
        }

        private void lstTasks_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
        }

        private void lstTasks_ItemCheck(object sender, ItemCheckEventArgs e)
        {
           
        }

        private void lstTasks_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string clientName = "";
            if (lstTasks.SelectedItems.Count != 0)
            {
                processID = lstTasks.SelectedItems[0].Text;
                clientName = lstTasks.SelectedItems[0].SubItems[2].Text;
                string sql = "DELETE FROM tblSettings WHERE SettingsID = '" + processID + "'";
                DialogResult res = MessageBox.Show("This will delete the selected task for client [" + clientName + "], proceed?", "Delete task", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.Yes)
                {
                    dbUtilities.ExecuteUpdate(sql);
                    MessageBox.Show("Task deleted.", "Delete Settings", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ControlSettings.SetTextToNull(grpAddTask);
                    ControlSettings.SetComboToFirstItem(cmbNameFormat);
                    ControlSettings.SetAllRadioButtonToFalse(grpAddTask);
                    cmbSelected.SelectedIndex = 1;

                    PopulateListView();
                    grpAddTask.Enabled = false;
                    grpScheduledTask.Enabled = true;

                }
            }
        }
        private void showLogHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLogHistory frm = new frmLogHistory();
            frm.ShowDialog();
        }

        private void txtClientName_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void txtClientName_KeyDown(object sender, KeyEventArgs e)
        {
            /*if (e.KeyCode == Keys.Enter)
            {
                MessageBox.Show(ControlSettings.RemoveQuotes(txtClientName.Text));
            }*/
        }

        private void txtClientName_TextChanged(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
