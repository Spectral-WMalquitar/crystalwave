using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DatabaseUtilities;
using ControlUtilities;

namespace FileSynchronization
{
    public partial class frmAddTask : Form
    {
        DBUtil dbUtilities;
        public static bool recordSaved = false;

        public frmAddTask()
        {
            InitializeComponent();
            dbUtilities = new DBUtil();
        }

        private void frmAddTask_Load(object sender, EventArgs e)
        {

        }

        private void btnBrowSource_Click(object sender, EventArgs e)
        {
            txtSourcePath.Text = dbUtilities.RunOpenDialog("Select the file to be copied from.");
        }

        private void btnBrowDesti_Click(object sender, EventArgs e)
        {
            string destinationPath = dbUtilities.RunOpenDialog("Select the folder to be copied to.");
            txtDestinationPath.Text = destinationPath.Substring(0,destinationPath.LastIndexOf("\\") + 1);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(dbUtilities.GenID(false, 10));
            string sql = "INSERT INTO tblSettings VALUES ('" + dbUtilities.GenID(false, 10) + "','" + txtClientName.Text + "'," +
                         "'" + txtSourcePath.Text + "','" + txtDestinationPath.Text + "'," + optCreateBak.Checked + "," +
                         "" + optOverwrite.Checked + ",'" + cmbNameFormat.Text + "',#" + DateTime.Now.ToString() + "#,'" + Environment.MachineName + "')";
            DialogResult res = MessageBox.Show("This will save your settings. Continue saving?", "Save Settings", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                dbUtilities.ExecuteQuery(sql);
                MessageBox.Show("Settings saved!", "Save Settings", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ControlSettings.SetTextToNull(this);
                ControlSettings.SetComboToFirstItem(cmbNameFormat);
                ControlSettings.SetAllRadioButtonToFalse(this);
                //ControlSettings.SetControlEnabled(this, false, new String[] { "TextBox", "Button", "ComboBox" });
                recordSaved = true;

                //frmFileSync fileSync = new frmFileSync();
                //fileSync.tmrFileSync.Enabled = true;
                //PopulateListView();
                this.Dispose();
                this.Close();

            }
        }
    }
}
