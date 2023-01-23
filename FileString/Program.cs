using System.IO;

namespace FileString
{
    internal class StringFile
    {
        static void Main(string[] args)
        {

            //PrintNum printNum = new PrintNum("ex1");
            // NewFile newFile = new NewFile("ex2_3","ex",500);
            //   CreateNewFile createNewFile = new CreateNewFile();

            //  for (int I = 0; I < 300; I++)
            //  {
            //     createNewFile.Log("Event", "bay");
            //    createNewFile.Log("Error", "hi");
            // }
            //Run run = new Run();
            //run.runner();

            // StringFile printer = new StringFile("A");
            // printer.PrintString();
            // StringFile printer1 = new StringFile("B");
            //// printer.PrintString();

            //  Files newFile = new Files(Console.ReadLine();
            //NewThread newThread = new NewThread("a", 500, 10);
            //NewThread newThread2 = new NewThread("b", 1000, 10);
            //NewThread newThread3 = new NewThread("a", 500, 100);
            //NewThread newThread4 = new NewThread("b", 1000, 100);
            //NewThread newThread5 = new NewThread("c", 250, 100);


            //ex 5
            Ex5_infinityThread ex5_InfinityThread = new Ex5_infinityThread("A", 500);
            Ex5_infinityThread ex5_InfinityThread1 = new Ex5_infinityThread("B", 500);
            Console.ReadLine();



        }


    }
}
