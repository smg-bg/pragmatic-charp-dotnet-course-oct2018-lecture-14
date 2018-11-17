using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesMore
{
    class Program
    {

        // non-generic delegate declaration (we would need multiple delegates
        // public delegate int SumIntDelegate(int a, int b);
        // public delegate float SumFloatDelegate(float a, float b);

        // generic delegate (there is a built in generic deleate Func<>)
        public delegate T SumDelegate<T>(T a, T b);  // Func<T1, T2, TRes>

        // generic delegate that does not return value (there is a built in generic delegate Action<>)
        public delegate void Log<T>(T msg);          // Action<T1>

        static void Main(string[] args)
        {
            SumDelegate<int> sumCalculator = delegate (int a, int b)
            {
                return a + b;
            };

            SumDelegate<int> secondSumCalculator = sumCalculator;

            Console.WriteLine(secondSumCalculator(3, 4));


            // Func<> does not require same generic parameter types
            Func<float, double, int> funcSumCalculator = delegate (float a, double b)
            {
                return (int)Math.Round(a + b);
            };

            Console.WriteLine(funcSumCalculator(7, 7));

            Action<string> actionHelloWorld = delegate (string name)
            {
                Console.WriteLine($"Hello, {name}");
            };

            actionHelloWorld("Marto");

            Console.WriteLine("Press any key to continue..");
            Console.ReadKey();
        }
    }
}
