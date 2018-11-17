using System;
using System.Collections.Generic;
using System.Linq;


namespace LambdaExpressions
{
    class Program
    {
        public class Car
        {
            public string PlateNumber { get; set; }
            public string Owner { get; set; }
        }

        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>();

            // hard way to initialize a class (assuming there is no constructor)
            //Car car = new Car();
            //car.Owner = "Joro";
            //car.PlateNumber = "B 7777 BB";
            //cars.Add(car);

            // same as above (simpler inline initialization of class)
            cars.Add(new Car
            {
                Owner = "Joro",
                PlateNumber = "B 7777 BB"
            });

            cars.Add(new Car
            {
                Owner = "Marto",
                PlateNumber = "CB 9999 AA"
            });

            cars.Add(new Car
            {
                Owner = "Radoslav",
                PlateNumber = "CA 7777 CA"
            });

            // the hard way to do it (without lambda expression)
            //var joroCars = cars.Where(delegate (Car c)
            //{
            //    if (c.Owner == "Joro") return true;

            //    return false;
            //});

            // same as above (with lambda expession)
            var joroCars = cars.Where(c => c.Owner == "Joro")
                .Select(c => c.PlateNumber).ToArray();

            Console.WriteLine($"Plate = { joroCars.FirstOrDefault() }");

            // same as above (even simpler by passing the labda to the FirstOrDefault(...))
            Console.WriteLine($"Owner = { cars.FirstOrDefault(c => c.Owner == "Joro").Owner }");


            // using labda expression to define a deleate (Funk<> is a delegate!)
            Func<int, int, int> summerLong = (a, b) =>
            {
                return a + b;
            };

            // same as above (again simpler one liner)
            Func<int, int, int> summerShort = (a, b) => a + b;

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
