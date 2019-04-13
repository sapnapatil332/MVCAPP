using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;
using System.Text;

namespace MVCAPP.Utility
{
    public class ErrorHelper
    {
        public static void LogError(Exception ex)
        {
            string path = "D:\\c#60 video\\SapnaGitProject\\MVCAPP\\App_Code\\LogFile.txt";
            StringBuilder sb = new StringBuilder();
            sb.Append(Environment.NewLine);
            sb.Append("-----Error started here-----");
            sb.Append(Environment.NewLine);
            sb.Append(DateTime.Now.ToString());
            sb.Append(Environment.NewLine);
            sb.Append("Error message:"+ex.Message.ToString());
            sb.Append(Environment.NewLine);
            sb.Append("Error StackTrack:"+ex.StackTrace.ToString());
            sb.Append(Environment.NewLine);
            sb.Append("-------Error End Here--------");

            if (!File.Exists(path))
            {
                File.Create(path).Close();
            }

            File.AppendAllText(path, sb.ToString());
        }
    }
}