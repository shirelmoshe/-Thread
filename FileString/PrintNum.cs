using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileString
{
    internal class PrintNum
    {

        private readonly string _inputString;

        public PrintNum(string inputString)
        {
            _inputString = inputString;
        }

        public void myTread()
        {
            Thread thread = new Thread(PrintString);
            thread.Start();

        }
        public void PrintString()
        {



            for (int i = 1; i <= 10; i++)
            {
                string line = $"{i}. {_inputString}";
                Console.WriteLine(line);

            }

        }
    }
}
