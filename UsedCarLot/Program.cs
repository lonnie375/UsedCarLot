// See https://aka.ms/new-console-template for more information


using System.Diagnostics;
using UsedCarLot;

//Cars in the Used car lot
List<Car> cars = new()
{
new Car("Nikolai", "Model S",2017, 54999.9m),
new Car("Fourd", "Escapade", 2017, 31999.9m), 
new Car("Chewie", "Vette", 2017, 44989.95m), 
new UsedCar("Hyonda", "Prior", 2015, 14795.50m, 35987.6),
new UsedCar("GC", "Chirpus", 2013, 8500m, 12345.0),
new UsedCar("GC", "Witherell", 2016, 14450m, 3500.3)
};

Console.WriteLine("Welcome to Grant Chirpus' Used Car Emporium!");
//Print the list of cars


var count = 1; 

foreach(var car in cars)
{
    Console.WriteLine($"{count}. {car}");
    count++; 
}
Console.WriteLine($"{count++}. Add");
Console.WriteLine($"{count++}. Quit"); 

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



