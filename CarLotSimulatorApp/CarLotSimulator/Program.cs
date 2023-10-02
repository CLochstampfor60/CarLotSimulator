using CarLotSimulator;
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;


//Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
var lot = new CarLot();

//Now that the Car class is created we can instanciate 3 new cars
//Set the properties for each of the cars
// Set the properties utilizing the 3 different ways we learned about, one way for each car
var car1 = new Car
{
    Year = 2018,
    Make = "Toyota",
    Model = "Tacoma",
    EngineNoise = "The engine noise is mid-level.",
    HonkNoise = "This vehicle's honk sound resembles a bicycle honker",
    IsDriveable = true,

};
lot.carList.Add(car1);

var car2 = new Car
{
    Year = 2023,
    Make = "Civic",
    Model = "Honda",
    EngineNoise = "The engine noise is low-level.",
    HonkNoise = "This vehicle's honk sound resembles the weekly neighborhood's ice-cream van visitin.",
    IsDriveable = true,
};
lot.carList.Add(car2);

var car3 = new Car(2022, "Ford", "Mustang", "The engine noise is a LOUD-level.", "This vehicle's honk sound resembles a monster truck", false);
lot.carList.Add(car3);

//Call each of the methods for each car
Console.WriteLine($"\n The first vehicle is a {car1.Year} {car1.Make} {car1.Model}. Is it drivable? {car1.IsDriveable}.");
car1.MakeEngineNoise(car1.EngineNoise);
car1.MakeHonkeNoise(car1.HonkNoise);

Console.WriteLine($"\n The second vehicle is a {car2.Year} {car2.Make} {car2.Model}.  Is it drivable? {car2.IsDriveable}.");
car2.MakeEngineNoise(car2.EngineNoise);
car2.MakeHonkeNoise(car2.HonkNoise);

Console.WriteLine($"\n The third vehicle is a {car3.Year} {car3.Make} {car3.Model}.  Is it drivable? {car3.IsDriveable}.");
car3.MakeEngineNoise(car3.EngineNoise);
car3.MakeHonkeNoise(car3.HonkNoise);


var truck = new Car
{
    Year = 2022,
    Make = "Ram",
    Model = "1500",
};

var SUV = new Car
{
    Year = 2023,
    Make = "Buick",
    Model = "Encore",
};

var midSize = new Car
{
    Year = 2021,
    Make = "Kona",
    Model = "Electric",
};


lot.carList.Add(truck);
lot.carList.Add(SUV);
lot.carList.Add(midSize);


//At the end iterate through the list printing each of car's Year, Make, and Model to the console

Console.WriteLine("\n The following cars were added to the lot:");
foreach (var car in lot.carList)
{
    Console.WriteLine($"{car.Year}, {car.Make} {car.Model} ");
}