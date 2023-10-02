using System;
using System.Security.Cryptography.X509Certificates;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {

            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
        var car1 = new Car
            {
                Year = 2018,
                Make = "Toyota",
                Model = "Tacoma",
                EngineNoise = "The engine noise is mid-level.",
                HonkNoise = "This vehicle's honk sound resembles resembles a bicycle honker",
                IsDriveable = true,

            };

        var car2 = new Car
        {
            Year = 2023,
            Make = "Civic",
            Model = "Honda",
            EngineNoise = "The engine noise is low-level.",
            HonkNoise = "This vehicle's honk sound resembles the weekly neighborhood's ice-cream van visitin.",
            IsDriveable = true,
            };

            var car3 = new Car
            {
                Year = 2022,
                Make = "Ford",
                Model = "Mustang",
                EngineNoise = "The engine noise is a LOUD-level.",
                HonkNoise = "This vehicle's honk sound resembles a monster truck",
                IsDriveable = false,
            };

            //Call each of the methods for each car
            Console.WriteLine($"\n The first vehicle is a {car1.Year} {car1.Make} {car1.Model}.");
            car1.MakeEngineNoise(car1.EngineNoise);
            car1.MakeHonkeNoise(car1.HonkNoise);

            Console.WriteLine($"\n The second vehicle is a {car2.Year} {car2.Make} {car2.Model}.");
            car2.MakeEngineNoise(car2.EngineNoise);
            car2.MakeHonkeNoise(car2.HonkNoise);

            Console.WriteLine($"\n The third vehicle is a {car3.Year} {car3.Make} {car3.Model}.");
            car3.MakeEngineNoise(car3.EngineNoise);
            car3.MakeHonkeNoise(car3.HonkNoise);



            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console
        }
    }
}
