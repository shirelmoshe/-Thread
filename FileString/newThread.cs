using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileString
{
    public  class NewThread
    {
       public  int length { set; get; }
        public string val { set; get; }
        public int sleepTime { get; set; }

        Thread thread;

        public NewThread(string Val,int Time , int Length)
        {
            val = Val;
            sleepTime = Time;
            length = Length;


            thread = new Thread(RunThread);
            thread.Start();
        }

        public void RunThread()
        {
            for(int i = 0; i < length; i++)
            {
                Console.WriteLine($"{i} - {val}");
                Thread.Sleep(sleepTime);

            }

        }

  


    }
     

}
