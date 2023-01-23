using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileString
{

    public class Files
    {


        private readonly string _inputString;

        public Files(string inputString)
        {
            _inputString = inputString;
            FileExists(_inputString);
        }

        public void FileExists(string _inputString)
        {


            string str1;


            if (!File.Exists(_inputString + ".txt"))
            {
                string fileNew = _inputString + ".txt";
                //str1 = File.ReadAllLines(_inputString + ".txt");
                FileStream file = File.Create(fileNew);




            }
            else
            {
              


            }

            
        }

        

    }
}
