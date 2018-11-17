using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    // global delegate
    public delegate void Log(string msg);

    class Program
    {
        // nested delegate in class Program
        public delegate float Power(float a, byte exp);


        static void Main(string[] args)
        {
            Log logger;

            // it's not possible to use the variable 
            // prior to its initialization 
            //logger(string.Empty);

            // (1) calling a method the normal way
            //FileLog("msg");

            // assigning a method to a variable of type delegate
            // only possible if the return type and the number and 
            // each individual type of the arguments are the same
            //logger = FileLog;

            // using the variable to call the method
            // same as (1)
            //logger("This is my message");

            logger = (args.Length > 0 && args[0] == "verbose")
                     ? (Log)ConsoleLog
                     : FileLog;

            logger("This will be printed");

            DoWork(logger);

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }

        static void DoWork(Log logger)
        {
            logger("10% complete");

            //...

            logger("99% complete");
        }

        static void FileLog(string msg)
        {
            // TODO: will be implemented in the next lecture
        }

        static void ConsoleLog(string msg)
        {
            Console.WriteLine(msg);
        }
    }
}
