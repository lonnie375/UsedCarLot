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
bool choice = true;
do
{


    var count = 1;

    foreach (var car in cars)
    {
        Console.WriteLine($"{count}. {car}");
        count++;

    }

    Console.WriteLine($"Add");
    //string userQuit = Console.ReadLine();
    Console.WriteLine($"Quit");
    //string userAdd = Console.ReadLine();

    /*
    if (userAdd == "y")
    {
        Console.WriteLine("Please provide the make: ");
        string userMake = Console.ReadLine();
        Console.WriteLine("Please provide the model: ");
        string userModel = Console.ReadLine();
        Console.WriteLine("Please provide the year: ");
        string userYear = Console.ReadLine();
        int year;
        bool user = int.TryParse(userYear, out year);
        Console.WriteLine("Please provide the price: ");
        string userPrice = Console.ReadLine();
        decimal price;
        bool usersPrice = decimal.TryParse(userPrice, out price);

        Car userNewCar = new Car(userMake, userModel, year, price);
        cars.Add(userNewCar);

        var counter = 1;
        foreach (var car in cars)
        {
            Console.WriteLine($"{counter}. {car}");
            counter++;
        }
   
    }
    */
        /*
        if (userQuit == "y")
        {
            Console.WriteLine("Good bye!");
            break;
        }
        else if (userQuit == "n")
        {

        }
        */
        Console.Write("Which car would you like? ");
        string userInput = (Console.ReadLine());
        int userChoice;
        bool userTest = int.TryParse(userInput, out userChoice);

        //Produce the car based on the number the user selects 
        if (userChoice == 1)
        {
            Console.WriteLine(cars[0]);

        }
        else if (userChoice == 2)
        {
            Console.WriteLine(cars[1]);
        }
        else if (userChoice == 3)
        {
            Console.WriteLine(cars[2]);
        }
        else if (userChoice == 4)
        {
            Console.WriteLine(cars[3]);
        }
        else if (userChoice == 5)
        {
            Console.WriteLine(cars[4]);
        }
        else if (userChoice == 6)
        {
            Console.WriteLine(cars[5]);
        }
        else if (userInput == "Add")
        {
    Console.WriteLine("Please provide the make: ");
    string userMake = Console.ReadLine();
    Console.WriteLine("Please provide the model: ");
    string userModel = Console.ReadLine();
    Console.WriteLine("Please provide the year: ");
    string userYear = Console.ReadLine();
    int year;
    bool user = int.TryParse(userYear, out year);
    Console.WriteLine("Please provide the price: ");
    string userPrice = Console.ReadLine();
    decimal price;
    bool usersPrice = decimal.TryParse(userPrice, out price);

    Car userNewCar = new Car(userMake, userModel, year, price);
    cars.Add(userNewCar);

    var counter = 1;
    foreach (var car in cars)
    {
        Console.WriteLine($"{counter}. {car}");
        counter++;
    }
}
        else if (userInput == "Quit")
        {
            Console.WriteLine("Good bye!");
            break;
        }
        else
        {
           
        }

        Console.Write("Would you like to buy it (y/n)? ");
        string userPurchase = Console.ReadLine();

        if (userPurchase == "y")
        {
            Console.WriteLine("Excellent!  Our finance department will be in touch shortly!");
            cars.RemoveAt(userChoice - 1);
            //remove 
        }
        else
        {
            //continue;
        }
    } while (choice == true);







