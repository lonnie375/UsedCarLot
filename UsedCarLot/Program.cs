// See https://aka.ms/new-console-template for more information


using System.Diagnostics;
using UsedCarLot;


//Cars in the Used car lot
List<UsedCar> newCar = new()
{
new UsedCar() { make = "Nikolai", model = "Model S", year = 2017, price = 54999.9m },
new UsedCar() { make = "Fourd", model = "Escapade", year = 2017, price = 31999.9m },
new UsedCar() { make = "Chewie", model = "Vette", year = 2017, price = 44989.95m },
new UsedCar() { make = "Hyonda", model = "Prior", year = 2015, price = 14795.50m, mileage = 35987.6},
new UsedCar() { make = "GC", model = "Chirpus", year = 2013, price = 8500m, mileage = 12345.0},
new UsedCar() { make = "GC", model = "Witherell", year = 2016, price = 14450m, mileage = 3500.3},

};

Console.WriteLine("Welcome to Grant Chirpus' Used Car Emporium!");
//Print the list of cars
/*
int count = 1; 
foreach (var cars in newCar)
{
    
    Console.WriteLine($"{count}. {cars.make} {cars.model} {cars.year} ${cars.price}       {cars.mileage} miles.");
    count++; 
}

Console.WriteLine($"{count++}. Add car");
Console.WriteLine($"{count++}. Quit");
*/

Car c = new Car();
UsedCar used = new UsedCar();
var test = c.ToString();

Console.WriteLine(test);


Console.Write("Which car would you like? ");
string userInput = (Console.ReadLine());
int userChoice;
bool userTest = int.TryParse(userInput, out userChoice);

//Confirms that the user enters an integer 
if (userTest)
{

}
else
{
    Console.WriteLine("Please enter a number next to the car you want to purchase: "); 
}

//Produce the car based on the number the user selects 



