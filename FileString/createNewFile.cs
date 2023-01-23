using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;

namespace FileString
{
    internal class CreateNewFile
    {
    
        public string WriteToFile { get; set; }
        public int timeSleep { get; set; }
       /// <summary>
       /// public object objectNew = new object();
       /// </summary>
        public string FileName{get;set; } = @"C:\Users\User\source\repos\FileString\mylog.txt";


       

        public void Log( string type ,string txt)
        {

            CheckFileSize();
            using (StreamWriter sw = new StreamWriter(FileName, true))
            {
                sw.WriteLine($"Log {type} : {DateTime.Now} - {txt}");
            }
        }

        

        public void createFile()
        {
            int counter = 1;

            while (System.IO.File.Exists(FileName))
            {

                FileName = @$"C:\Users\User\source\repos\FileString\mylog{counter}.txt";
                counter++;

            }
            using (FileStream file = new FileStream(FileName, FileMode.Create)) ;

        }
        public void CheckFileSize()
        {

            if (!System.IO.File.Exists(FileName)) { using (FileStream file = new FileStream(FileName, FileMode.Create)) ; }

            else
            {
                var fi1 = new FileInfo(FileName);
                if (fi1.Length >= 5000)
                {
                    createFile();
                }
            }
            

        }
        

    }
}
