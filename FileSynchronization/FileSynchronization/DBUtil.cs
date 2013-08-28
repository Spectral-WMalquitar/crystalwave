using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Windows.Forms;

namespace DatabaseUtilities
{
    class DBUtil
    {
        static OleDbCommand cmd;
        static OleDbDataReader rd;
        public static bool isSuccess = false;  
        private OleDbConnection conn;
        private string ConnStr;

        public DBUtil()
        {
            try
            {
                ConnStr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + @"\FileSyncDB.accdb";
                conn = new OleDbConnection(ConnStr);
                cmd = new OleDbCommand();
                conn.Open();
                isSuccess = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("There is a problem connecting on the database.", "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                isSuccess = false;
            }
        }

        public OleDbConnection GetConnection()
        {
            return conn;
        }
        public OleDbDataReader ExecuteQuery(string sql)
        {
            try
            {
                cmd.CommandText = sql;
                cmd.Connection = this.GetConnection();
                return cmd.ExecuteReader();
            }
            catch (System.InvalidOperationException IOE)
            {
                MessageBox.Show(IOE.Message + " : " + IOE.Source);
                return null;
            }
        }

        public void ExecuteUpdate(string sql)
        {
            try
            {
                cmd.CommandText = sql;
                cmd.Connection = this.GetConnection();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " : " + ex.Source);
            }
        }

        public void LoadDetailsToListBox(ListBox lst, string sql)
        {
            DBUtil.rd = ExecuteQuery(sql);
            while (DBUtil.rd.Read())
            {
                lst.Items.Add(DBUtil.rd[0].ToString().ToUpper());
            }
            DBUtil.rd.Close();
        }

        public string RunOpenDialog(string title)
        {
            OpenFileDialog openDialog = new OpenFileDialog();
            openDialog.Title = title;
            if (openDialog.ShowDialog() == DialogResult.OK)
                return openDialog.FileName;
            else
                return "";
        }
        public string RunFolderBrowserDialog()
        {
            FolderBrowserDialog folderBrowser = new FolderBrowserDialog();
            if (folderBrowser.ShowDialog() == DialogResult.OK)
                return folderBrowser.SelectedPath.ToString();
            else
                return "";
        }
        public string GenID(bool isNumeric, int charCount)
        {
            Random rnd = new Random();
            string retVal = "";
            for (int i = 0; i < charCount; i++)
            {
                if (isNumeric)
                    retVal += rnd.Next(1, 10).ToString();
                else
                    retVal += Convert.ToChar(rnd.Next(65, 90)).ToString();
            }
            return retVal;
        }
    }
}
