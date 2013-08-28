using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace FileSyncUtilities
{
    class FileSync
    {
        private string sourceFile;
        private string destiFile;
        private bool overWrite;
        private string nameFormat;
        private string trueFileName;
        private string statusReport;
        private string clientName;
        public FileSync(string clientName, string sFile, string dFile, bool oWrite, string nFormat )
        {
            this.sourceFile = sFile;
            this.destiFile = dFile;
            this.overWrite = oWrite;
            this.nameFormat = nFormat;
            this.trueFileName = sFile.Substring(sFile.LastIndexOf('\\'));
            this.clientName = clientName;
        }
        public bool runFileSync()
        {
            return ProcessFileSync(this.sourceFile, this.destiFile);
        }
        public bool ProcessFileSync(string source, string destination)
        {
            string oldFileName = destination + trueFileName;
            string backUpFileName = destination + ConfigureNameFormat(this.nameFormat);
            try
            {
                if (File.Exists(oldFileName))
                {
                    if (this.overWrite == true)
                        File.Delete(oldFileName);
                    else
                    {
                        File.Move(oldFileName, backUpFileName);
                        File.Delete(oldFileName);
                    }
                }
                File.Copy(source, oldFileName);
                statusReport = " - Client (" + clientName + ") - File succesfully copied from [" + source + "] and saved to [" + oldFileName + "]. " + Environment.NewLine +
                               "" + (this.overWrite == true? "" : "Backup created as  [" + backUpFileName + "].");
                return true;
            }
            catch (Exception ex)
            {
                statusReport =" - Copying failed for [" + source + "] and saved to [" + oldFileName + "] due to [" + ex.Message + "]." +  Environment.NewLine ;
                return false;  
            }
        }

        private string ConfigureNameFormat(string nameFormat)
        {
            string fileYear = DateTime.Now.Year.ToString().Substring(2);
            string fileMonth = ConvertToZeroTrail(DateTime.Now.Month, DateTime.Now.Month.ToString());
            string fileDay = ConvertToZeroTrail(DateTime.Now.Day, DateTime.Now.Day.ToString());
            string fileHour = ConvertToZeroTrail(DateTime.Now.Hour, DateTime.Now.Hour.ToString());
            string fileMin = ConvertToZeroTrail(DateTime.Now.Minute, DateTime.Now.Minute.ToString());
            string fileSec = ConvertToZeroTrail(DateTime.Now.Second, DateTime.Now.Second.ToString());
            string fileName = sourceFile.Substring(sourceFile.LastIndexOf('\\'));
            string extensionName = sourceFile.Substring(sourceFile.LastIndexOf('.'));
            fileName = fileName.Remove(fileName.LastIndexOf('.'));
            switch (nameFormat)
            {
                case "YYMMDD_HHMMSS":
                    return fileName + "_" + fileYear + fileDay + fileMonth + "_" + fileHour + fileMin + fileSec + extensionName;
                default:
                    return fileName + "_" + fileYear + fileDay + fileMonth + extensionName;
            }
        }

        private string ConvertToZeroTrail(int val, string origVal)
        {
            return (val > 9 ? origVal : "0" + origVal);
        }

        public string GetStatusReport()
        {
            return this.statusReport;
        }
    }
}
