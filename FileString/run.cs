using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileString
{
    internal class Run
    {
        public void runner()
        {
            for (int i = 0; i < 4; i++)
            {
                NewFile newFile = new NewFile(Console.ReadLine(), 500);
            }
        }




    }
}
