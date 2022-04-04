using System;
using System.Collections.Generic;
using System.IO; 
using System.Text; 

namespace WriteLogToText
{
    public class cSetLog
    {
        public static bool C_PRCbWriteLog(string ptErrorLog1)
        {
            StringBuilder oSql;
            string tDteTme;
            try
            {
                oSql = new StringBuilder();
                tDteTme = DateTime.Now.ToString();
                oSql.Append("Error log is : " + ptErrorLog1 + " Time : " + tDteTme);
                File.AppendAllText(Environment.SpecialFolder.ProgramFiles + "log.txt", oSql.ToString());
                oSql.Clear();
                return true;
            }
            catch (Exception oEx)
            {
                return false;
            }


        } 

    }
}

