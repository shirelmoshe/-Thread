using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileString
{
    public  class NewFile
    {
        private string _FileName;
        public string WriteToFile { get; set; } 
        public int timeSleep { get; set; }
        public object objectNew = new object();
        public string FileName
        {
            get { return _FileName; }
            set { _FileName = value+ ".txt"; }
        }

      
        public NewFile( string fileName,int time)
        {
            FileName = fileName;
            timeSleep = time;
            Task.Run(FileExists);
         

        }

        public void FileExists( )
        {

            lock (objectNew)
            {
                if (!(File.Exists(FileName)))
                {
                    using (FileStream file = new FileStream(FileName, FileMode.Create)) ;
                    Console.WriteLine("1");
                }
                using (StreamWriter sw = new StreamWriter(FileName, true))
                {

                    Random random = new Random(DateTime.Now.Millisecond);
                    for (int i = 0; i < 10000; i++)
                    {

                        int randomNum = random.Next(10000);

                        sw.WriteLine(randomNum);
                    }


                    
                }
                
            }
           
            Thread.Sleep(timeSleep);
        }


        


    }

}
