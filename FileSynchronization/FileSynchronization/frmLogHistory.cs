using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace FileSynchronization
{
    public partial class frmLogHistory : Form
    {
        public frmLogHistory()
        {
            InitializeComponent();
        }

        private void frmLogHistory_Load(object sender, EventArgs e)
        {
            string logPath = @"C:\FileSyncLog\FileSyncLog.log";
            if (File.Exists(logPath))
            {
                txtLogHistory.Text = File.ReadAllText(logPath);
            }
        }

        private void txtLogHistory_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
