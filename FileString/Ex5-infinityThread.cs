using DocumentFormat.OpenXml.Drawing.Charts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileString
{
    public class Ex5_infinityThread
    {
        private static bool Continue = true;
        public string val { set; get; }
        public int sleepTime { get; set; }
        public object obj = new object();
        Thread thread;
        public Ex5_infinityThread(string Val, int Time)
        {
            val = Val;
            sleepTime = Time;
            // Task.Run(RunThread);
            thread = new Thread(RunThread);
            thread.Start();
        }

        public void RunThread()
        {
            int i = 1;
            while (Continue)
            {
                if (!(i % 10 == 0))
                {
                   
                    Console.WriteLine($"{i} - {val} - {System.Threading.Thread.CurrentThread.ManagedThreadId}");
                }
                else
                {

             
                        Console.WriteLine("please enter a number : ");
                        string stringUserNum = Console.ReadLine();
                  

                        if (int.TryParse(stringUserNum, out int NumericValue))
                        {
                            int userNumber = int.Parse(stringUserNum);
                            if (userNumber == 0) Continue = false;

                        }
                    
                }
                Thread.Sleep(sleepTime);
                i++;
            }

        }






    }
}






